   M S B A M L   `   `   `  ���� ?  ;kobe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kobe.View	kobe.View  /clr-namespace:kobe.Converterkobe.Converter  #    kobe.View.StudentDataPageView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:kobe.View     2	converterclr-namespace:kobe.Converter     -   $��studentInfo��  � 	Resources  $   kobe.Converter.GenderConverter   genderConverter �� 
TargetType  CommitButtonTemplate �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value  GenderRadioButtonTemplate	 � ColumnDefinitions  TextBox.Static.Border
 �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  StudentTextBoxStyle �� 
TargetType-  'System.Windows.Input.KeyboardNavigation ��Name J� SnapsToDevicePixels ��Name �� Value �� Binding �� RelativeSource �� Mode �� Triggers ]� 
Conditions �� Property �� Value��%�  &	        &	      &	 �     &	 -    &	 B    &	 W    &	 l    7  7  7    �� " ��.R��� ���#007DFA$ 10��._�� .+��� $
��back��$ 4�����	#22FFFFFF$y�Hidden=��� #��z��$��Center=�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $
 back�� � y�$ Visible=��� " 	�.R�� 	 �� $
��auto ��� .+��� $��20��$��20��$ 10��$��1q����#007DFA
�������$	��5,0q�$��Center=�._��� $��point��$��8��$��8��$ 4�����#007DFA$y�	Collapsed=��� #��z��$��Center=�$��1�� P�  �@d�	IsChecked$
 TrueY�. ��� $ point�� � y�$ Visible=��� $
 	#FFABAdB3���� $
 	#FF7EB4EA���� $
 	#FF569DE5���� " ��.���  � ��# � ����  � ��8   ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ border��$��0q�
������� . $ 10��._�� .+��� $��mt��$��请输入姓名��$��1��$��Center=�
�������$y�	Collapsed=��� $ PART_ContentHost��$��1��|�.  $��Hidden=�$��Hidden=�$��Center=�
������  P�  � {� .  . ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8   � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8   � ���� $  �� �� *Text+ �� $
 Self=�.a��� $ mt�� � y�$ Visible=� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush# � /�.��� 	 �� �� $��3* � � RowDefinitions �� $
��auto ��� .+��� 
��������� 
�������$��1��� $��1�� �� �� �� �� �� �� �� �� .+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� $��姓名��$��16(�$��Center=�$
��Bold"��� $��32��$	��180��$
��10,0q�#��[ ���� *StudentModel.StuName+.���� $ 
Horizontal=�$��Center=�$��Center=�$��1��.+��� $��年龄��$��16(�$��Center=�$
��Bold"��� $��32��$	��180��$
��10,0q�#��[ ���� *StudentModel.StuAge+.���� $ 
Horizontal=�$��Center=�$��Center=�$��2��.+��� $��性别��$��16(�$��Center=�$
��Bold"�$
��10,0q�	� $	��男��$��10,0,0,0q�$��16(�#��[  d� 	IsChecked �� *StudentModel.StuSex+ �� 	Converter# [   �� ConverterParameter$ 1��	� $	��女��$��10,0,0,0q�$��16(�#��[  �� *StudentModel.StuSex+# [  $ 0���� $ 
Horizontal=�$��Center=�$��Center=�$��3��.+��� $��年级��$��16(�$��Center=�$
��Bold"��� -   $��sc��$��32��$	��180��$
��10,0q� �� SelectedValue �� *StudentModel.StuClass+.@��� $��	一年级���� $��	二年级���� $��	三年级���� $��	四年级���� $��	五年级���� $��	六年级���� $��初一���� $��初二���� $��初三���� $��高一���� $��高二���� $��高三���� $ 
Horizontal=�$��Center=�$��Center=�$��4��.+��� $��	身份证��$��16(�$��Center=�$
��Bold"��� $��32��$	��180��$
��10,0q�#��[ ���� *StudentModel.StuIDcard+.���� $ 
Horizontal=�$��Center=�$��Center=�$��5��.+��� $��	手机号��$��16(�$��Center=�$
��Bold"��� $��32��$	��180��$
��10,0q�#��[ ���� *StudentModel.StuPhone+.���� $ 
Horizontal=�$��6��$��Center=�.+��� $��清空��$��6��$��32��$	��100��$
��10,0q�
�������$��16(�#��[  � Cursor$
 Hand���� $��提交��$��6��$��32��$	��100��$
��10,0q�
�������$��16(�#��[ $
 Hand������ *AddStudentInfoCommand+����  �� ElementName$ studentInfo���� 
���  ��$
��Bold"�$��7��$��40��$��20(�$��Center=����� *ErrorMessage+�� $��1��.+��� 
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect      Color$
  Gray��!   ShadowDepth$! 0Q�"   
BlurRadius$" 5Q�#   Opacity$	# 0.3Q�$   	Direction$$ 0Q�._�� $��30��	 �� $��80 ��� $��80 ��� $��80 ��� $��80 ��� $	��240 ��� $	��160 ��� .+��� $��0,0,1,0q�
�������$	��0,5q��� $��0,0,1,0q�
�������$	��0,5q�$��1���� $��0,0,1,0q�
�������$	��0,5q�$��2���� $��0,0,1,0q�
�������$	��0,5q�$��3���� $��0,0,1,0q�
�������$	��0,5q�$��4���� $��0,0,1,0q�
�������$	��0,5q�$��5���� $��	姓   名��
�������$��Center=�$��Center=�$��14(�$
��Bold"��� $��	年   龄��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��1���� $��	性   别��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��2���� $��	年   级��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��3���� $��身 份 证��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��4���� $��手 机 号��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��5���� $��	操   作��
�������$��Center=�$��Center=�$��14(�$
��Bold"�$��6���� $��1��$��1��$��Hidden=�.���� -   $��MyView������ *studentlist+���� .R�$� ���� .R��� 
�������$ 5��$	��0,5q�   $
  Gray��$! 0Q�$" 5Q�$	# 0.3Q�$$ 0Q�._�� $��30��	 �� $��80 ��� $��80 ��� $��80 ��� $��80 ��� $	��240 ��� $	��160 ��� .+��� $y�Hidden=����� *StuID+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"����� *	StuName+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��1������ *StuAge+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��2������ *StuSex+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��3������ *
StuClass+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��4������ *	StuIDcard+�� ���#3F4C5D$��Center=�$��Center=�$��14(�$
��Bold"�$��5������ *
StuPhone+�� $��删除��$��6��$��20��$��50��
�������$��16(�#��[ $
 Hand��$��6������ *&$DataContext.DeleteStudentInfoCommand+ �� % �� AncestorType$% UserControlL�$ FindAncestor=����� *StuID+