   M S B A M L   `   `   `  ���� ?  ;kobe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kobe.View	kobe.View  +    %kobe.View.StudentAttendDetailPageView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:kobe.View       � 	Resources   �� 
TargetType   CommitButtonTemplate �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value  TextBox.Static.Border
 �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  GradeTextBoxStyle �� 
TargetType-  'System.Windows.Input.KeyboardNavigation J� SnapsToDevicePixels ��Name ��Name �� Value �� Binding �� RelativeSource �� Mode �� Triggers ]� 
Conditions �� Property �� Value��%]  &	        &	 �     &	 �     &	     &	 $    7  7  7  �� " ��.R��� ���#007DFA$ 10��._�� .+��� $
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
 Self=�.a��� $ mt�� � y�$	 Visible=� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush#	 � /�.���� 
�������._��  � ColumnDefinitions ��  � RowDefinitions �� $��40 ��� $
��auto ��� .+��� $��1��.+��� 
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$
 Gray��   ShadowDepth$ 0Q�   
BlurRadius$ 5Q�   Opacity$	 0.3Q�   	Direction$ 0Q�._�� $��30�� �� �� �� �� �� �� .+��� $��0,0,1,0q�
�������$	��0,5q��� $��0,0,1,0q�
�������$	��0,5q�$��1���� $��0,0,1,0q�
�������$	��0,5q�$��2���� $��0,0,1,0q�
�������$	��0,5q�$��3���� $��0,0,1,0q�
�������$	��0,5q�$��4���� $��学 生 名��
�������$��Center=�$��Center=�$��14(�$
��Bold"��� $��课 程 名��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��1���� $��教 师 名��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��2���� $��课  周��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��3���� $��签到时间��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��4���� $��	操   作��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��5���� $��2��$��Hidden=�.���� ���� *studentattendlist+���� .R�$� ���� .R��� 
�������$ 5��$	��0,5q�   $
 Gray��$ 0Q�$ 5Q�$	 0.3Q�$ 0Q�._�� $��30�� �� �� �� �� �� �� .+��� $��0,0,1,0q�
���   �$	��0,5q��� $��0,0,1,0q�
���   �$	��0,5q�$��1���� $��0,0,1,0q�
���   �$	��0,5q�$��2���� $��0,0,1,0q�
���   �$	��0,5q�$��3���� $��0,0,1,0q�
���   �$	��0,5q�$��4���� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"����� *	StuName+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��1������ *
CourseName+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��2������ *	TeaName+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��3������ *
CourseWeek+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��4������ *
AttendTime+�� $��删除��$��20��$��50��
�������$��16(�$��5�� � Cursor$
 Hand��#��[  