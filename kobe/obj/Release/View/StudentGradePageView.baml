   M S B A M L   `   `   `  ���� ?  ;kobe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kobe.View	kobe.View  $    kobe.View.StudentGradePageView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:kobe.View     -   $��	gradeInfo��  � 	Resources   �� 
TargetType   CommitButtonTemplate �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value  TextBox.Static.Border
 �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  GradeTextBoxStyle �� 
TargetType-  'System.Windows.Input.KeyboardNavigation J� SnapsToDevicePixels ��Name ��Name �� Value �� Binding �� RelativeSource �� Mode �� Triggers ]� 
Conditions �� Property �� Value  ContentStyle��%�  &	        &	 �     &	 �     &	     &	 $    7  7  7  &	     �� " ��.R��� ���#007DFA$ 10��._�� .+��� $
 back��$ 4�����	#22FFFFFF$y�Hidden=��� #��z��$��Center=�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $
 back�� � y�$	 Visible=��� $
 	#FFABAdB3���� $
 	#FF7EB4EA���� $
 	#FF569DE5���� " ��.���  � ��#	 � ����  � ��8	   ��  � ��#	 � ����  � ��$	 1q���  �@ TabNavigation$
	 None=���  � ��$
	 Left=���  �@�FocusVisualStyle	 Z� ��  �@J�	AllowDrop	 . ��  �@��PanningMode$	 VerticalFirst=���  �@��IsFlicksEnabled	 .  ��  � ��	 �� " ��.R��� $ border��$��0q�
������� . $ 10��._�� .+��� $ mt��$��请输入姓名��$��1��$��Center=�
�������$y�	Collapsed=��� $ PART_ContentHost��$��1��|�.  $��Hidden=�$��Hidden=�$��Center=�
������  P�  � {� .  . ��� $ border�� �@J�Opacity$
	 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8	   � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8	   � ���� $  �� �� *Text+ �� $
 Self=�.a��� $ mt�� � y�$	 Visible=� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush#	 � /��� " ��.���  � ��$	 Center=���  � ��$	 Center=���  � ��$
	 Wrap=���  � ��
	 �   �.���� ���#F5F6FA._��  � ColumnDefinitions �� �� $��3* � � RowDefinitions �� $��40 ��� $
��auto ��� .+��� 
�������$��1���� 
�������$��2��$ 10��$��15q�._�� $��2�� �� �� �� �� �� �� .+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� $��	学生名��$��16(�$��Center=�$
��Bold"��� $��32��$	��150��$
��10,0q� �� DisplayMemberPath$ StuName�� �� SelectedValuePath$ StuID������ *studentlist+ �� SelectedValue �� *GradeModel.StuID+�� $ 
Horizontal=�$��Center=�$��Center=�$��1��.+��� $��	课程名��$��16(�$��Center=�$
��Bold"��� $��32��$	��150��$
��10,0q�$ 
CourseName��$ CourseID������ *
courselist+ �� *GradeModel.CourseID+�� $ 
Horizontal=�$��Center=�$��Center=�$��2��.+��� $��考试类别��$��16(�$��Center=�$
��Bold"��� $��32��$	��150��$
��10,0q�#��[ ���� *GradeModel.TestLevel+.���� $ 
Horizontal=�$��Center=�$��Center=�$��3��.+��� $��成绩��$��16(�$��Center=�$
��Bold"��� $��32��$	��150��$
��10,0q�#��[ ���� *GradeModel.Grade+.���� $ 
Horizontal=�$��4��$��Center=�.+��� $��清空��$��6��$��32��$	��100��$
��10,0q�
�������$��16(�#��[   � Cursor$
 Hand���� $��提交��$��6��$��32��$	��100��$
��10,0q�
�������$��16(�#��[  $
 Hand������ *AddStudentGradeInfoCommand+����  �� ElementName$ 	gradeInfo���� 
���  ��$
��Bold"�$��5��$��40��$��20(�$��Center=����� *ErrorMessage+�� 
�������$��1��$��2��$ 10��$��15q�� $��1��$��2��$��15q� �� $��50 ��� .+��� $��15 0 0 0q�$��Center=�$��Student Grade��$��22(����#959595&   System.Windows.Controls.DataGrid  $��1��
������    HeadersVisibility$ Column=�    AutoGenerateColumns  .  !   CanUserAddRows! .  "   VerticalGridLinesBrush
" ���� #   HorizontalGridLinesBrush
# �����$��0q����� *studentgradelist+$   ColumnHeaderStyle$ �� =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  � ��$	 0q���  � ��$	 Center=���  � ��$	 Center=���  � ��
	 ���� ��  � ��	 �#959595��  � ��$
	 Bold"���  � ��$	 35��%   RowStyle% �� )  #System.Windows.Controls.DataGridRow"  .���  � ��$	 40����  � ��	 �#959595��  � ��$	 Center=���  � ��$	 Center=�&   Columns& 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn'   Header$' ID��(   Width5  /System.Windows.Controls.DataGridLengthConverter$( * )   
Visibility$) Hidden=�1  +System.Windows.Controls.DataGridBoundColumn*   Binding* �� *ID+  $' 	学生名��$( * +   ElementStyle#+ [ * �� *	StuName+  $' 	课程名��$( * #+ [ * �� *
CourseName+  $' 考试类别��$( * #+ [ * �� *	TestLevel+  $' 考试成绩��$( * #+ [ * �� *Grade+4	  .System.Windows.Controls.DataGridTemplateColumn	  $' 操作��$( * , 	  CellTemplate, �� .R��� $��删除��$��20��$��50��
�������$��16(�#��[  $
 Hand��$��4������ *+)DataContext.DeleteStudentGradeInfoCommand+ �� - �� AncestorType"- >�$ FindAncestor=����� *ID+