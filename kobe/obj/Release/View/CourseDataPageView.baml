   M S B A M L   `   `   `  ���� ?  ;kobe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kobe.View	kobe.View  b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes "    kobe.View.CourseDataPageView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:kobe.View     ^ThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     -     >�Name$  
courseInfo�� � 	Resources  �� 
TargetType   CommitButtonTemplate �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName	 �� Property
 �� Value  TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  CourseTextBoxStyle �� 
TargetType-  'System.Windows.Input.KeyboardNavigation J� SnapsToDevicePixels ��Name ��Name �� Value �� Binding �� RelativeSource �� Mode �� Triggers ]� 
Conditions �� Property �� Value��%]  &	        &	 �     &	 �     &	     &	 $    7  7  7  �� " ��.R��� ���#007DFA$ 10��._�� .+��� $
 back��$ 4�����	#22FFFFFF$y�Hidden=��� #��z��$��Center=�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $
 back��	 � y�$
 Visible=��� $ 	#FFABAdB3���� $ 	#FF7EB4EA���� $ 	#FF569DE5���� " ��.��� 	 � ��#
 � ���� 	 � ��8
   �� 	 � ��#
 � ���� 	 � ��$
 1q��� 	 �@ TabNavigation$

 None=��� 	 � ��$

 Left=��� 	 �@�FocusVisualStyle
 Z� �� 	 �@J�	AllowDrop
 . �� 	 �@��PanningMode$
 VerticalFirst=��� 	 �@��IsFlicksEnabled
 .  �� 	 � ��
 �� " ��.R��� $ border��$��0q�
������� . $ 10��._�� .+��� $ mt��$��请输入姓名��$��1��$��Center=�
�������$y�	Collapsed=��� $ PART_ContentHost��$��1��|�.  $��Hidden=�$��Hidden=�$��Center=�
������  P�  � {� .  . ��� $ border��	 �@J�Opacity$

 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8
  	 � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8
  	 � ���� $  �� �� *Text+ �� $
 Self=�.a��� $ mt��	 � y�$
 Visible=� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./��� 	 �@��SelectionBrush#
 � /�.���  � ColumnDefinitions �� �� $��3* � � RowDefinitions �� $
��auto ��� .+��� 
��������� 
�������$��1��� $��1�� �� �� �� �� �� .+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� $��	课程名��$��16(�$��Center=�$
��Bold"��� $��32��$	��180��$
��10,0q�#��[ ���� *CourseModel.CourseName+�� $ 
Horizontal=�$��Center=�$��Center=�$��1��.+��� $��课程类别��$��16(�$��Center=�$
��Bold"��� $��32��$	��180��$
��10,0q�#��[ ���� *CourseModel.CourseType+�� $ 
Horizontal=�$��Center=�$��Center=�$��2��.+��� $��课时��$��16(�$��Center=�$
��Bold"��� -   $��ch��$��32��$	��180��$
��10,0q� �� SelectedIndex �� *CourseModel.CourseHour+.@��� $�� ���� $��1小时���� $��2小时���� $��3小时���� $��4小时���� $��5小时���� $��6小时���� $ 
Horizontal=�$��3��$��Center=�.+��� $��清空��$��6��$��32��$	��100��$
��10,0q�
�������$��16(�#��[   � Cursor$
 Hand���� $��提交��$��6��$��32��$	��100��$
��10,0q�
�������$��16(�#��[  $
 Hand������ *AddCourseInfoCommand+����  �� ElementName$ 
courseInfo���� 
���  ��$
��Bold"�$��4��$��40��$��20(�$��Center=����� *ErrorMessage+�� $��1��.+��� 
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$
 Gray��    ShadowDepth$  0Q�!   
BlurRadius$! 5Q�"   Opacity$	" 0.3Q�#   	Direction$# 0Q�._�� $��30�� �� �� �� �� .+��� $��0,0,1,0q�
�������$	��0,5q��� $��0,0,1,0q�
�������$	��0,5q�$��1���� $��0,0,1,0q�
�������$	��0,5q�$��2���� $��课 程 名��
�������$��Center=�$��Center=�$��14(�$
��Bold"��� $��课程类别��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��1���� $��	课   时��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��2���� $��	操   作��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��3���� $��1��$��1��$��Hidden=�.���� ���� *
courselist+���� .R�$� ���� .R��� 
�������$ 5��$	��0,5q�   $
 Gray��$  0Q�$! 5Q�$	" 0.3Q�$# 0Q�._�� $��30�� �� �� �� �� .+��� $y�Hidden=����� *
CourseID+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"����� *
CourseName+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��1������ *
CourseType+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��2������ *
CourseHour+�� $��删除��$��6��$��20��$��50��
�������$��16(�#��[  $
 Hand��$��3������ *%#DataContext.DeleteCourseInfoCommand+ �� $ �� AncestorType"$ >�$ FindAncestor=����� *
CourseID+