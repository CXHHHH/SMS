   M S B A M L   `   `   `  ���� ?  ;kobe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kobe.View	kobe.View  #    kobe.View.DailyAffairPageView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:kobe.View       � 	Resources     TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border �� 
TargetType  NavButtonStyle �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value
 �� 
TargetName  SearchTextBoxStyle-  'System.Windows.Input.KeyboardNavigation ��Name J� SnapsToDevicePixels � ColumnDefinitions ��Name �� Value �� Binding �� RelativeSource �� Mode �� Triggers ]� 
Conditions �� Property �� Value��%�  &	        &	      &	 *     &	 ?     &	 6    7   7  7  �� $ 	#FFABAdB3���� $ 	#FF7EB4EA���� $ 	#FF569DE5���� " 	�.���  � �� �#3F4C5D��  � �� �� " 	�.R��� $
��back��
������ $ 8��._��� #��z��$��Center=�$��Center=�$
��20,4q�$��18(� P�  �@d�	IsChecked$
	 TrueY�. ��� $

 back�� � �� �#C0C0C0�� " ��.���  � ��# � ����  � ��8   ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ border��$��0q����#3F4C5D . $ 10��._��  �� $��30 ��� .+��� $	����$��../Assets/Fonts/#iconfont)�$��Center=�$��Center=����	#44FFFFFF$��18(��� $��mt��$��请输入搜索的内容��$��1��$��Center=�
�������$y�	Collapsed=��� $ PART_ContentHost��$��1��|�.  $��Hidden=�$��Hidden=�$��Center=�
������  P�  � {�	 .  . ��� $
 border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver	 . . ��� $
 border��8   � ��P�  �@J�IsKeyboardFocused	 . . ��� $
 border��8   � ���� $  �� �� *Text+ �� $
 Self=�.a��� $
 mt�� � y�$ Visible=� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush# � /�.���  � RowDefinitions �� $��60 ��� $��60 ��� .+��� $ 5,5,0,0�����#F5F6FA�� $��日常处理�����#3F4C5D$��10,0,0,0q�$��Center=�$��24(�$
��Bold"��� $��Center=�$��Right=�$	��300��$��32��$��0,0,10,0q�
�������#��[ ���� *
SearchText+�� ���#F5F6FA$��1����  �� Orientation$ 
Horizontal=�$��1��$
��Left=�$��Center=�.+�	� $��学生签到��#��[  d� 	IsChecked$
 TrueY�$��StudentAttendancePageView������ *NavChangedCommand+	� $��学生成绩��#��[ $��StudentGradePageView������ *NavChangedCommand+	� $��考勤统计��#��[ $!��StudentAttendDetailPageView������ *NavChangedCommand+�� $��1��$��0,0,0,1q�
���   ��� $��2������ *DataContent+