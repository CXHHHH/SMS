   M S B A M L   `   `   `  ����?  ;kobe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kobe.View	kobe.View  5          kobe.View.DataPageView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:kobe.View     5        � 	Resources  5	         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border �� 
TargetType  NavButtonStyle �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value
 �� 
TargetName  SearchTextBoxStyle-  'System.Windows.Input.KeyboardNavigation ��Name J� SnapsToDevicePixels � ColumnDefinitions ��Name �� Value �� Binding �� RelativeSource �� Mode �� Triggers ]� 
Conditions �� Property �� Value��%�	  &	        &	 #     &	 F     &	 i     &	 (    7   7  7  �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " 	�6   .�5      ��  � �� �#3F4C5D6+   �� 5       � �� 5      �� 5      " 	�6&   .R�5      �� $
��back��6K   
������ $ 8��6:   ._�5      �� #��z��6-   $��Center=�6Q   $��Center=�6l   $
��20,4q�6�   $��18(�6�   5       5      P� 5       �@d�	IsChecked$
	 TrueY�6;   . �5   "   �� $

 back��6)    � �� �#C0C0C06Q   5      5      5      5      �� 5!   
   " ��6+   .�5"      ��  � ��# � ��6+   �� 5#       � ��8   6,   �� 5$       � ��# � ��6+   �� 5%       � ��$ 1q�60   �� 5&       �@ TabNavigation$
 None=�6A   �� 5'       � ��$
 Left=�6;   �� 5(       �@�FocusVisualStyle 61   Z� �� 5)       �@J�	AllowDrop . 6*   �� 5*       �@��PanningMode$ VerticalFirst=�69   �� 5+       �@��IsFlicksEnabled .  67   �� 5,       � �� 5-      �� 5.      " ��6&   .R�5/      �� $ border��6!   $��0q�61   ���#3F4C5D . $ 10��50      ._�51      �  52   "   �� 53   &   $��30 �67   �� 54   &   .+�56   "   �� $	����6,   $��../Assets/Fonts/#iconfont)�6<   $��Center=�6c   $��Center=�6�   ���	#44FFFFFF$��18(�57   ;   �� 58   "   $��mt��6z   $��请输入搜索的内容��6,   $��1��6<   $��Center=�6L   
�������$y�	Collapsed=�6�   �� 59   "   $ PART_ContentHost��6/   $��1��6I   |�.  $��Hidden=�6k   $��Hidden=�5:   #   $��Center=�6H   
������ 5;   #   5<      5=       5>      P� 5?       � {�	 .  . �5@   "   �� $
 border��6<    �@J�Opacity$
 0.56Q�6P   5A      P� 5B       �@J�IsMouseOver	 . . �5C   "   �� $
 border��6@   8   � ��6T   5D      P� 5E       �@J�IsKeyboardFocused	 . . �5F   "   �� $
 border��6@   8   � ��6T   5G      �� 5H      $  ��6m    6*   �� *Text+ �� $
 Self=�.a�5I   "   �� $
 mt��6)    � y�$ Visible=�6O   5J      5L      5N       5O      ]� 5P       5Q      �� 5R      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5S       �@��IsSelectionActive .  6A   ./�5U      ��  �@��SelectionBrush# � /�67   5V      5X      5Y      .��5Z      �  � RowDefinitions 5[   
   �� 5\      $��60 �6   �� 5]      $��60 �6   �� 5^      .+�5`   
   �� $ 5,5,0,0��6   
�������6(   �� 5b   
   $��信息管理��6   ���#3F4C5D$��10,0,0,0q�65   $��Center=�6G   $��24(�6b   $
��Bold"�6p   �� 5c   
   $��Center=�6   $��Right=�6.   $	��300��6J   $��32��6V   $��0,0,10,0q�6c   
�������#��[ 5d   K   ��6   �� *
SearchText+6K   �� 5f   
   
�������$��1��6$   �� 5g   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $
��Left=�6;   $��Center=�6V   .+�5h      	� $��学生信息管理��6   #��[ 6+    d� 	IsChecked$
 TrueY�6S   $��StudentDataPageView��5j      ��5i      �� *NavChangedCommand+5j      	� 5k      $��老师信息管理��6   #��[ 6+   $��TeacherDataPageView��5m      ��5l      �� *NavChangedCommand+5m      	� 5n      $��课程信息管理��6   #��[ 6+   $��CourseDataPageView��5p      ��5o      �� *NavChangedCommand+5p      	� 5q      $��课程老师绑定��6   #��[ 6+   $��CourseTeacherPageView��5s      ��5r      �� *NavChangedCommand+5s      	� 5t      $��学生报名课程��6   #��[ 6+   $��CourseStudentPageView��5v      ��5u      �� *NavChangedCommand+5v      5w      �� 5y   
   $��2��6   ��6&   �� *DataContent+5{      5|      