using kobe.Common;
using kobe.DataAccess.DataEntity;
using kobe.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Data.SQLite;

namespace kobe.DataAccess
{
    public class LocalDataAccess
    {
        private static LocalDataAccess instance;

        private LocalDataAccess() { }

        public static LocalDataAccess GetInstance()
        {
            return instance ?? (instance = new LocalDataAccess());
        }

        

        SQLiteConnection conn;

        SQLiteCommand comm;
        SQLiteDataAdapter adapter;

        private void Dispose()
        {
            if(adapter != null)
            {
                adapter.Dispose();
                adapter = null;
            }
            if(comm != null)
            {
                comm.Dispose();
                comm = null;
            }
            if(conn != null)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }

        private bool DBConnection()
        {
            string connstr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            if (conn == null)
                conn = new SQLiteConnection(connstr);
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public UserEntity CheckUserInfo(string username,string pwd)
        {
            try
            {
                if (DBConnection())
                {
                    string usersql = "select * from users where user_name=@user_name and password=@pwd and is_vaild=1";
                    adapter = new SQLiteDataAdapter(usersql, conn);
                    
                    adapter.SelectCommand.Parameters.Add(new SQLiteParameter("@user_name", DbType.String) { Value = username });
                    adapter.SelectCommand.Parameters.Add(new SQLiteParameter("@pwd", DbType.String) { Value = 
                        MD5Provider.GetMD5String(pwd + "@"+username) });

                    DataTable table = new DataTable();
                    int count = adapter.Fill(table);

                    if (count <= 0)
                        throw new Exception("用户名或密码不正确！");

                    DataRow dr = table.Rows[0];
                    if (dr.Field<Int32>("is_canlogin") == 0)
                        throw new Exception("当前用户没有权限使用改平台");

                    UserEntity userinfo = new UserEntity();
                    userinfo.UserName = dr.Field<string>("user_name");
                    userinfo.RealName = dr.Field<string>("real_name");
                    userinfo.PassWord = dr.Field<string>("password");
                    userinfo.Avatar = dr.Field<string>("avatar");
                    userinfo.Gender = dr.Field<Int32>("gender");

                    return userinfo;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();

            }
            return null;

        }

        public List<StudentModel> GetStudentInfo()
        {
            try
            {
                List<StudentModel> sModelList = new List<StudentModel>();
                if (DBConnection())
                {
                    string usersql = "select stu_id,stu_name,stu_age,stu_sex,stu_class,stu_idcard,stu_phone from student";
                    adapter = new SQLiteDataAdapter(usersql, conn);

                    DataTable table = new DataTable();
                    int count = adapter.Fill(table);

                    StudentModel smodel = null;

                    foreach(DataRow dr in table.AsEnumerable())
                    {
                        smodel = new StudentModel();
                        smodel.StuID= dr.Field<string>("stu_id");
                        smodel.StuName = dr.Field<string>("stu_name");
                        smodel.StuAge = dr.Field<Int32>("stu_age");
                        if(dr.Field<Int32>("stu_sex") == 1)
                        {
                            smodel.StuSex = "男";
                        }
                        else
                        {
                            smodel.StuSex = "女";
                        }
                        smodel.StuClass = dr.Field<string>("stu_class");
                        smodel.StuIDcard = dr.Field<string>("stu_idcard");
                        smodel.StuPhone = dr.Field<string>("stu_phone");

                        sModelList.Add(smodel);
                    }
                }
                return sModelList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();

            }
            return null;
        }

        public bool AddStudentInfo(StudentModel sModel)
        {
            try
            {
                string StuID = "TFXS" + DateTime.Now.ToString("yyMMddHHmmss");
                if (DBConnection())
                {
                    string addstusql = @"insert into student(stu_id,stu_name,stu_age,stu_sex,stu_class,stu_idcard,stu_phone,create_time,is_del)values
                                       (@stu_id,@stu_name,@stu_age,@stu_sex,@stu_class,@stu_idcard,@stu_phone,datetime('now', 'localtime'),0)";
                    SQLiteCommand com = new SQLiteCommand(addstusql, conn);

                    com.Parameters.Add(new SQLiteParameter("@stu_id", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@stu_name", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@stu_age", DbType.Int32));
                    com.Parameters.Add(new SQLiteParameter("@stu_sex", DbType.Int32));
                    com.Parameters.Add(new SQLiteParameter("@stu_class", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@stu_idcard", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@stu_phone", DbType.String));
                    //给参数赋值 
                    com.Parameters["@stu_id"].Value = StuID;
                    com.Parameters["@stu_name"].Value = sModel.StuName;
                    com.Parameters["@stu_age"].Value = sModel.StuAge;
                    com.Parameters["@stu_sex"].Value = 1;
                    com.Parameters["@stu_class"].Value = sModel.StuClass;
                    com.Parameters["@stu_idcard"].Value = sModel.StuIDcard;
                    com.Parameters["@stu_phone"].Value = sModel.StuPhone;

                    com.ExecuteNonQuery();
                    conn.Close();


                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.Dispose();

            }
            return false;
        }

        public bool DeleteStudentInfo(string stuid)
        {
            try
            {
                if (DBConnection())
                {
                    string delstusql = @"delete from student where stu_id =@stu_id;delete from course_student where stu_id =@stu_id;";
                    SQLiteCommand com = new SQLiteCommand(delstusql, conn);

                    com.Parameters.Add(new SQLiteParameter("@stu_id", DbType.String));
                    ////给参数赋值 
                    com.Parameters["@stu_id"].Value = stuid;

                    com.ExecuteNonQuery();


                    conn.Close();


                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.Dispose();

            }
            return false;
        }

        public List<TeacherModel> GetTeacherInfo()
        {
            try
            {
                List<TeacherModel> tModelList = new List<TeacherModel>();
                if (DBConnection())
                {
                    string usersql = "SELECT tea_id,tea_name,tea_age,tea_sex,tea_idcard,tea_phone FROM teacher";
                    adapter = new SQLiteDataAdapter(usersql, conn);

                    DataTable table = new DataTable();
                    int count = adapter.Fill(table);

                    TeacherModel tmodel = null;

                    foreach (DataRow dr in table.AsEnumerable())
                    {
                        tmodel = new TeacherModel();
                        tmodel.TeaID = dr.Field<string>("tea_id");
                        tmodel.TeaName = dr.Field<string>("tea_name");
                        tmodel.TeaAge = dr.Field<Int32>("tea_age");
                        if (dr.Field<Int32>("tea_sex") == 1)
                        {
                            tmodel.TeaSex = "男";
                        }
                        else
                        {
                            tmodel.TeaSex = "女";
                        }
                        tmodel.TeaIDcard = dr.Field<string>("tea_idcard");
                        tmodel.TeaPhone = dr.Field<string>("tea_phone");

                        tModelList.Add(tmodel);
                    }
                }
                return tModelList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();

            }
            return null;
        }

        public List<string> GetTeacherName()
        {
            try
            {
                List<string> result = new List<string>();
                if (this.DBConnection())
                {
                    string sql = "select tea_name from teacher";
                    adapter = new SQLiteDataAdapter(sql, conn);

                    DataTable table = new DataTable();
                    int count = adapter.Fill(table);
                    if (count > 0)
                    {
                        result = table.AsEnumerable().Select(c => c.Field<string>("tea_name")).ToList();
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();

            }
            return null;
        }

        public bool AddTeacherInfo(TeacherModel tModel)
        {
            try
            {
                string TeaID = "TFLS" + DateTime.Now.ToString("yyMMddHHmmss");
                if (DBConnection())
                {
                    string addstusql = @"insert into teacher(tea_id,tea_name,tea_age,tea_sex,tea_idcard,tea_phone,create_time,is_del)values
                                        (@tea_id,@tea_name,@tea_age,@tea_sex,@tea_idcard,@tea_phone,datetime('now', 'localtime'),0)";
                    SQLiteCommand com = new SQLiteCommand(addstusql, conn);

                    com.Parameters.Add(new SQLiteParameter("@tea_id", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@tea_name", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@tea_age", DbType.Int32));
                    com.Parameters.Add(new SQLiteParameter("@tea_sex", DbType.Int32));
                    com.Parameters.Add(new SQLiteParameter("@tea_idcard", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@tea_phone", DbType.String));
                    //给参数赋值 
                    com.Parameters["@tea_id"].Value = TeaID;
                    com.Parameters["@tea_name"].Value = tModel.TeaName;
                    com.Parameters["@tea_age"].Value = tModel.TeaAge;
                    com.Parameters["@tea_sex"].Value = tModel.TeaSex;
                    com.Parameters["@tea_idcard"].Value = tModel.TeaIDcard;
                    com.Parameters["@tea_phone"].Value = tModel.TeaPhone;

                    com.ExecuteNonQuery();
                    conn.Close();


                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.Dispose();

            }
            return false;
        }

        public bool DeleteTeacherInfo(string teaid)
        {
            try
            {
                if (DBConnection())
                {
                    string addstusql = @"delete from teacher where tea_id =@tea_id;delete from course_teacher where tea_id =@tea_id;";
                    SQLiteCommand com = new SQLiteCommand(addstusql, conn);

                    com.Parameters.Add(new SQLiteParameter("@tea_id", DbType.String));
                    //给参数赋值 
                    com.Parameters["@tea_id"].Value = teaid;

                    com.ExecuteNonQuery();
                    conn.Close();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.Dispose();

            }
            return false;
        }

        public List<CourseModel> GetCourseInfo()
        {
            try
            {
                List<CourseModel> cModelList = new List<CourseModel>();
                if (DBConnection())
                {
                    string usersql = "select course_id,course_name,course_hour,course_type from course";
                    adapter = new SQLiteDataAdapter(usersql, conn);

                    DataTable table = new DataTable();
                    int count = adapter.Fill(table);

                    CourseModel cmodel = null;

                    foreach (DataRow dr in table.AsEnumerable())
                    {
                        cmodel = new CourseModel();
                        cmodel.CourseID = dr.Field<string>("course_id");
                        cmodel.CourseName = dr.Field<string>("course_name");
                        cmodel.CourseHour = dr.Field<Int32>("course_hour");
                        cmodel.CourseType= dr.Field<string>("course_type");

                        cModelList.Add(cmodel);
                    }
                }
                return cModelList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();

            }
            return null;
        }

        public bool AddCourseInfo(CourseModel cModel)
        {
            try
            {
                string courseID = "C" + DateTime.Now.ToString("yyMMddHHmmss");
                if (DBConnection())
                {
                    string addstusql = @"insert into course(course_id,course_name,course_hour,course_type,create_time,is_del)values
                                            (@course_id,@course_name,@course_hour,@course_type,datetime('now', 'localtime'),0)";
                    SQLiteCommand com = new SQLiteCommand(addstusql, conn);

                    com.Parameters.Add(new SQLiteParameter("@course_id", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@course_name", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@course_hour", DbType.Int32));
                    com.Parameters.Add(new SQLiteParameter("@course_type", DbType.String));
                    //给参数赋值 
                    com.Parameters["@course_id"].Value = courseID;
                    com.Parameters["@course_name"].Value = cModel.CourseName;
                    com.Parameters["@course_hour"].Value = cModel.CourseHour;
                    com.Parameters["@course_type"].Value = cModel.CourseType;

                    com.ExecuteNonQuery();
                    conn.Close();


                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.Dispose();

            }
            return false;
        }


        public bool DeleteCourseInfo(string courseid)
        {
            try
            {
                if (DBConnection())
                {
                    string addstusql = @"delete from course where course_id=@course_id";
                    SQLiteCommand com = new SQLiteCommand(addstusql, conn);

                    com.Parameters.Add(new SQLiteParameter("@course_id", DbType.String));
                    //给参数赋值 
                    com.Parameters["@course_id"].Value = courseid;


                    com.ExecuteNonQuery();
                    conn.Close();


                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.Dispose();

            }
            return false;
        }


        public List<CourseStudentModel> GetCourseTeacherInfo()
        {
            try
            {
                List<CourseStudentModel> ctModelList = new List<CourseStudentModel>();
                if (DBConnection())
                {
                    string usersql = @"select ct.id,c.course_name,t.tea_name,ct.course_week,ct.course_class from course_teacher ct 
                                        left join course c on ct.course_id = c.course_id
                                        left join teacher t on ct.tea_id = t.tea_id
                                        order by ct.course_week";
                    adapter = new SQLiteDataAdapter(usersql, conn);

                    DataTable table = new DataTable();
                    int count = adapter.Fill(table);

                    CourseStudentModel ctmodel = null;

                    foreach (DataRow dr in table.AsEnumerable())
                    {
                        ctmodel = new CourseStudentModel();
                        ctmodel.ID = (int)dr.Field<long>("id");
                        ctmodel.CourseName = dr.Field<string>("course_name");
                        ctmodel.TeaName = dr.Field<string>("tea_name");
                        ctmodel.CourseWeek = dr.Field<string>("course_week");
                        ctmodel.CourseClass = dr.Field<string>("course_class");

                        ctModelList.Add(ctmodel);
                    }
                }
                return ctModelList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();

            }
            return null;
        }


        public bool AddCourseTeacherInfo(CourseStudentModel ctModel)
        {
            try
            {
                if (DBConnection())
                {
                    string addstusql = @"insert into course_teacher(course_id,tea_id,course_week,course_class,create_time,is_del)values
                                            (@course_id,@tea_id,@course_week,@course_class,datetime('now', 'localtime'),0)";
                    SQLiteCommand com = new SQLiteCommand(addstusql, conn);

                    com.Parameters.Add(new SQLiteParameter("@course_id", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@tea_id", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@course_week", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@course_class", DbType.String));
                    //给参数赋值 
                    com.Parameters["@course_id"].Value = ctModel.CourseID;
                    com.Parameters["@tea_id"].Value = ctModel.TeaId;
                    com.Parameters["@course_week"].Value = ctModel.CourseWeek;
                    com.Parameters["@course_class"].Value = ctModel.CourseClass;

                    com.ExecuteNonQuery();
                    conn.Close();


                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.Dispose();

            }
            return false;
        }

        public List<CourseStudentModel> GetCourseStudentInfo()
        {
            try
            {
                List<CourseStudentModel> csModelList = new List<CourseStudentModel>();
                if (DBConnection())
                {
                    string usersql = @"select cs.id,s.stu_name,c.course_name,t.tea_name,ct.course_week,ct.course_class from course_student cs 
                                        left join course_teacher ct on ct.course_id = cs.course_id
                                        left join course c on ct.course_id = c.course_id
                                        left join teacher t on ct.tea_id = t.tea_id
                                        left join student s on cs.stu_id = s.stu_id
                                        order by ct.course_week";
                    adapter = new SQLiteDataAdapter(usersql, conn);

                    DataTable table = new DataTable();
                    int count = adapter.Fill(table);

                    CourseStudentModel csmodel = null;

                    foreach (DataRow dr in table.AsEnumerable())
                    {
                        csmodel = new CourseStudentModel();
                        csmodel.ID = (int)dr.Field<long>("id");
                        csmodel.StuName = dr.Field<string>("stu_name");
                        csmodel.CourseName = dr.Field<string>("course_name");
                        csmodel.TeaName = dr.Field<string>("tea_name");
                        csmodel.CourseWeek = dr.Field<string>("course_week");
                        csmodel.CourseClass = dr.Field<string>("course_class");

                        csModelList.Add(csmodel);
                    }
                }
                return csModelList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();

            }
            return null;
        }

        public bool AddCourseStudentInfo(CourseStudentModel csModel)
        {
            try
            {
                if (DBConnection())
                {
                    string addstusql = @"insert into course_student(stu_id,course_id,create_time,is_del)values
                                            (@stu_id,@course_id,datetime('now', 'localtime'),0)";
                    SQLiteCommand com = new SQLiteCommand(addstusql, conn);

                    com.Parameters.Add(new SQLiteParameter("@stu_id", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@course_id", DbType.String));
                    //给参数赋值 
                    com.Parameters["@stu_id"].Value = csModel.StuID;
                    com.Parameters["@course_id"].Value = csModel.CourseID;

                    com.ExecuteNonQuery();
                    conn.Close();


                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.Dispose();

            }
            return false;
        }

        public List<CourseStudentModel> GetStuTeaCourseInfo(string teacher , string weektime )
        {
            try
            {
                List<CourseStudentModel> csModelList = new List<CourseStudentModel>();
                if (DBConnection())
                {
                    string usersql = @"select cs.id,s.stu_id,s.stu_name,c.course_id,c.course_name,t.tea_id,t.tea_name,ct.course_week,ct.course_class from course_student cs 
                                        left join course_teacher ct on ct.course_id = cs.course_id
                                        left join course c on ct.course_id = c.course_id
                                        left join teacher t on ct.tea_id = t.tea_id
                                        left join student s on cs.stu_id = s.stu_id where 1=1 ";
                    if(teacher!="全部")
                    {
                        usersql += "and t.tea_name=" +"'" +teacher+"'";
                    }
                    if (weektime != "全部")
                    {
                        usersql += "and ct.course_week=" + "'"  +weektime + "'";
                    }

                    usersql += " order by s.stu_name";

                    adapter = new SQLiteDataAdapter(usersql, conn);


                    DataTable table = new DataTable();
                    int count = adapter.Fill(table);

                    CourseStudentModel csmodel = null;

                    foreach (DataRow dr in table.AsEnumerable())
                    {
                        csmodel = new CourseStudentModel();
                        csmodel.ID = (int)dr.Field<long>("id");
                        csmodel.StuID = dr.Field<string>("stu_id");
                        csmodel.CourseID = dr.Field<string>("course_id");
                        csmodel.TeaId = dr.Field<string>("tea_id");
                        csmodel.StuName = dr.Field<string>("stu_name");
                        csmodel.CourseName = dr.Field<string>("course_name");
                        csmodel.TeaName = dr.Field<string>("tea_name");
                        csmodel.CourseWeek = dr.Field<string>("course_week");
                        csmodel.CourseClass = dr.Field<string>("course_class");

                        csModelList.Add(csmodel);
                    }
                }
                return csModelList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();

            }
            return null;
        }

        public List<CourseStudentModel> GetStuAttendInfo(string teacher)
        {
            try
            {
                List<CourseStudentModel> csModelList = new List<CourseStudentModel>();
                if (DBConnection())
                {
                    string usersql = @"select stu_name,course_name, create_time FROM student_attend where create_time>=date('now','start of day')";
                    if (teacher != "全部")
                    {
                        usersql += "and tea_name=" + "'" + teacher + "'";
                    }

                    usersql += " order by stu_name";

                    adapter = new SQLiteDataAdapter(usersql, conn);


                    DataTable table = new DataTable();
                    int count = adapter.Fill(table);

                    CourseStudentModel csmodel = null;

                    foreach (DataRow dr in table.AsEnumerable())
                    {
                        csmodel = new CourseStudentModel();
                        csmodel.StuName = dr.Field<string>("stu_name");
                        csmodel.CourseName = dr.Field<string>("course_name");
                        csmodel.AttendTime = dr.Field<DateTime>("create_time").ToString("yyyy-MM-dd HH:mm:ss");

                        csModelList.Add(csmodel);
                    }
                }
                return csModelList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();

            }
            return null;
        }

        public List<CourseStudentModel> GetStudetailAttendInfo()
        {
            try
            {
                List<CourseStudentModel> csModelList = new List<CourseStudentModel>();
                if (DBConnection())
                {
                    string usersql = @"select stu_name,course_name,tea_name, course_week,create_time FROM student_attend ";

                    usersql += " order by create_time desc";

                    adapter = new SQLiteDataAdapter(usersql, conn);


                    DataTable table = new DataTable();
                    int count = adapter.Fill(table);

                    CourseStudentModel csmodel = null;

                    foreach (DataRow dr in table.AsEnumerable())
                    {
                        csmodel = new CourseStudentModel();
                        csmodel.StuName = dr.Field<string>("stu_name");
                        csmodel.CourseName = dr.Field<string>("course_name");
                        csmodel.TeaName = dr.Field<string>("tea_name");
                        csmodel.CourseWeek = dr.Field<string>("course_week");
                        csmodel.AttendTime = dr.Field<DateTime>("create_time").ToString("yyyy-MM-dd HH:mm:ss");

                        csModelList.Add(csmodel);
                    }
                }
                return csModelList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();

            }
            return null;
        }

        public bool AddStudentAttendInfo(CourseStudentModel csModel)
        {
            try
            {
                if (DBConnection())
                {
                    string addstusql = @"insert into student_attend(stu_name,course_name,tea_name,course_week,course_class,create_time,is_del)values
                                            (@stu_name,@course_name,@tea_name,@course_week,@course_class,datetime('now', 'localtime'),0)";
                    SQLiteCommand com = new SQLiteCommand(addstusql, conn);

                    com.Parameters.Add(new SQLiteParameter("@stu_name", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@course_name", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@tea_name", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@course_week", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@course_class", DbType.String));
                    //给参数赋值 
                    com.Parameters["@stu_name"].Value = csModel.StuName;
                    com.Parameters["@course_name"].Value = csModel.CourseName;
                    com.Parameters["@tea_name"].Value = csModel.TeaName;
                    com.Parameters["@course_week"].Value = csModel.CourseWeek;
                    com.Parameters["@course_class"].Value = csModel.CourseClass;

                    com.ExecuteNonQuery();
                    conn.Close();


                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.Dispose();

            }
            return false;
        }


        public List<GradeModel> GetStudentGradeInfo()
        {
            try
            {
                List<GradeModel> gModelList = new List<GradeModel>();
                if (DBConnection())
                {
                    string usersql = @"select g.id,s.stu_name,c.course_name,g.test_level,g.grade from grade g 
                                        left join course c on g.course_id = c.course_id
                                        left join student s on g.stu_id = s.stu_id
                                        order by g.grade";
                    adapter = new SQLiteDataAdapter(usersql, conn);

                    DataTable table = new DataTable();
                    int count = adapter.Fill(table);

                    GradeModel gmodel = null;

                    foreach (DataRow dr in table.AsEnumerable())
                    {
                        gmodel = new GradeModel();
                        gmodel.ID = (int)dr.Field<long>("id");
                        gmodel.StuName = dr.Field<string>("stu_name");
                        gmodel.CourseName = dr.Field<string>("course_name");
                        gmodel.TestLevel = dr.Field<string>("test_level");
                        gmodel.Grade = dr.Field<string>("grade");

                        gModelList.Add(gmodel);
                    }
                }
                return gModelList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();

            }
            return null;
        }

        public bool AddStudentGradeInfo(GradeModel gModel)
        {
            try
            {
                if (DBConnection())
                {
                    string addstusql = @"insert into grade(stu_id,course_id,test_level,grade,create_time,is_del)values
                                            (@stu_id,@course_id,@test_level,@grade,datetime('now', 'localtime'),0)";
                    SQLiteCommand com = new SQLiteCommand(addstusql, conn);

                    com.Parameters.Add(new SQLiteParameter("@stu_id", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@course_id", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@test_level", DbType.String));
                    com.Parameters.Add(new SQLiteParameter("@grade", DbType.String));
                    //给参数赋值 
                    com.Parameters["@stu_id"].Value = gModel.StuID;
                    com.Parameters["@course_id"].Value = gModel.CourseID;
                    com.Parameters["@test_level"].Value = gModel.TestLevel;
                    com.Parameters["@grade"].Value = gModel.Grade;

                    com.ExecuteNonQuery();
                    conn.Close();


                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.Dispose();

            }
            return false;
        }

        public bool DeleteGradeInfo(string id)
        {
            try
            {
                if (DBConnection())
                {
                    string delstusql = @"delete from grade where id =@id";
                    SQLiteCommand com = new SQLiteCommand(delstusql, conn);

                    com.Parameters.Add(new SQLiteParameter("@id", DbType.Int32));
                    ////给参数赋值 
                    com.Parameters["@id"].Value = id;

                    com.ExecuteNonQuery();

                    conn.Close();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.Dispose();

            }
            return false;
        }

    }
}
