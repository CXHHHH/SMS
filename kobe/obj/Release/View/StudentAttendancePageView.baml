   M S B A M L   `   `   `  ���� ?  ;kobe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kobe.View	kobe.View  )    #kobe.View.StudentAttendancePageView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:kobe.View     -     >�Name$  
attendInfo�� � 	Resources  �� 
TargetType   CommitButtonTemplate �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value  CategoryItemButtonTemplate  courseTemplate
 � ColumnDefinitions J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Color   ShadowDepth   
BlurRadius   Opacity   	Direction j� Stretch �� ImageSource �� Orientation �� Command �� RelativeSource �� AncestorType �� Mode �� CommandParameter �� Triggers }� Location $� Orientation �� 
LineHeight��%�  &	        &	 �     &	 �    �� " ��.R��� ���#007DFA$ 10��._�� .+��� $
��back��$ 4�����	#22FFFFFF$y�Hidden=��� #��z��$��Center=�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $
 back�� � y�$	 Visible=��� " 	�.R�� 
������ .+��� $
��back�����#EEE$ 5��._��� #��z��$��14(�$
��15,4q�$��Center=�$��Center=� P�  �@d�	IsChecked$
 TrueY�. ��� $
 back�� � ��
	 � �����  � ��
	 ������� .R�� .+�� $��courseContent��
 �� $	��150 ��� �� $	��100 �.+��� $��90��$��60��$ 5��$
��0,15q�   $
 Gray��$ 0Q�$ 10Q�$	 0.3Q�$ 0Q����� $ UniformToFill=� �� *Cover+�� $��1��$��Center=�.+��� $ 
Horizontal=�$��0,0,0,10q�.+��� $��16(��� ���#333 �� *" DataContext.OpenCourseUrlCommand+ �� $ UserControlL�$ FindAncestor=� �� *Url+.����� .���  � ��	 Z�  P�  �@��IsMouseOver . . ���  � ��	 |� }� $ 	Underline=�.�.��� ���� *
CourseName+�� $
��15,0q����� *
Teachers+���� .R�$� $ 
Horizontal=����� .R��� ���#EEE$	��5,0q�$ 5��._��� $
��12,3q����� �� $
��Wrap=�$ 23�����#AAA���� *Description+�� $ 
Horizontal=�$��2��$��Center=�$��Center=�.+��� $	��5,0q��� .�详情�� $	��5,0q��� .�删除.���� 
�������._��  � RowDefinitions �� $��40 ��� $��40 ��� .+��� $ 
Horizontal=�$��Center=�.+��� $��授课老师��$��18(�$��Center=�$
��20,0q����#666�� ���� *CategoryTeacher+���� .R��� $ 
Horizontal=����� .R�	� -   #��[ $	��5,0q� 	� 	GroupName$ teacher������ *CategoryName+ d� 	IsChecked �� *
IsSelected+�� $ 
Horizontal=�$��1��$��Center=�.+��� $��上课时间��$��18(�$��Center=�$
��20,0q����#666�� ���� *CategoryWorkTime+���� .R��� $ 
Horizontal=����� .R�	� -   #��[ $	��5,0q�$ WorkTime������ *CategoryName+ �� *
IsSelected+� $��2��
 �� �� $��20 ���  �� $
��auto ��� .+��� .+��� 
�������$ 5��   $
 Gray��$ 0Q�$ 5Q�$	 0.3Q�$ 0Q�._�� $��30��
 �� �� �� �� �� �� .+��� $��0,0,1,0q�
�������$	��0,5q��� $��0,0,1,0q�
�������$	��0,5q�$��1���� $��0,0,1,0q�
�������$	��0,5q�$��2���� $��0,0,1,0q�
�������$	��0,5q�$��3���� $��0,0,1,0q�
�������$	��0,5q�$��4���� $��学 生 名��
�������$��Center=�$��Center=�$��14(�$
��Bold"��� $��课 程 名��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��1���� $��任课老师��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��2���� $��	课   周��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��3���� $��	节   课��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��4���� $��	操   作��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��5���� $��1��$��Hidden=�.���� ���� *coursestudentlist+���� .R�$� ���� .R��� 
�������$ 5��$	��0,5q�   $
 Gray��$ 0Q�$ 5Q�$	 0.3Q�$ 0Q�._�� $��30��
 �� �� �� �� �� �� .+��� $y�Hidden=����� *ID+�� $y�Hidden=����� *StuID+�� $y�Hidden=����� *
CourseID+�� $y�Hidden=����� *TeaId+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"����� *	StuName+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��1������ *
CourseName+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��2������ *	TeaName+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��3������ *
CourseWeek+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��4������ *CourseClass+��   ��Name$  qd��$��签到��$��20��$��50��
�������$��16(�#��[  ! � Cursor$
! Hand��$��5������ *%#DataContext.AddStudentAttendCommand+ �� $ UserControlL�$ FindAncestor=����� �� $��2��.+��� 
�������$ 5��   $
 Gray��$ 0Q�$ 5Q�$	 0.3Q�$ 0Q�._�� $��30��
 �� �� �� .+��� $��0,0,1,0q�
�������$	��0,5q��� $��0,0,1,0q�
�������$	��0,5q�$��1���� $��学 生 名��
�������$��Center=�$��Center=�$��14(�$
��Bold"��� $��课 程 名��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��1���� $��签到时间��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��5���� $��2��$��1��$��Hidden=�.���� ���� *attendstudentlist+���� .R�$� ���� .R��� 
�������$ 5��$	��0,5q�   $
 Gray��$ 0Q�$ 5Q�$	 0.3Q�$ 0Q�._�� $��30��
 �� �� �� .+��� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"����� *	StuName+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��1������ *
CourseName+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��2������ *
AttendTime+