   M S B A M L   `   `   `  ���� ?  ;kobe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kobe.View	kobe.View  )clr-namespace:kobe.Commonkobe.Common      kobe.View.LoginView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:kobe.View     ,commonclr-namespace:kobe.Common     -   $��window��  � Title$  系统登录��$	��500��$	��360��$��Microsoft YaHei)�$��
ExtraLight"� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . ��Z�  � 	Resources  �� Source �� MergedDictionaries �� 
TargetType   Key	 �� CornerRadius
 �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value �� Color �� 
TargetType  TextBox.Static.Border-  'System.Windows.Input.KeyboardNavigation ��Name J� SnapsToDevicePixels � ColumnDefinitions ��Name  TextBox.MouseOver.Border  TextBox.Focus.Border �� Triggers ]� 
Conditions �� Property �� Value�� $( "../Assets/Styles/DefaultStyle.xaml?� �� �� " ��LoginButtonTemplate  .R��� ���#007DFA$	 5��._�� .+��� $
��back��$	 4�����	#22FFFFFF$y�Hidden=��� #��z��$��Center=�$��Center=�#��z��
 P�  �@J�IsMouseOver . . ��� $
 back�� � y�$ Visible=��� TextBox.Static.Border  $ 	#FFABAdB3���� TextBox.MouseOver.Border  $ 	#FF7EB4EA���� TextBox.Focus.Border  $ 	#FF569DE5���� UserNametext  " ��.���  � ��# � ����  � ��# [ ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ border��#��z��#��z��#��z�� . $	 5��._��  �� $��40 ��� .+��� $	����$��../Assets/Fonts/#iconfont)�$��20(�$��Center=�$��Center=����#DDD�� $ PART_ContentHost��$��1��|�.  $��Hidden=�$��Hidden=�$��Center=�$��20��
 P�  � {� .  . ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��# [  � ��P�  �@J�IsKeyboardFocused . . ��� $ border��# [  � �� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush# � /��� PasswordBoxStyle  " G�.���  �@G�PasswordChar$	 ●����  � ��# � ����  � ��# [ ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " G�.R��� $ border��#��z��#��z��#��z�� . $	 5��._��  �� $��40 ��� .+��� $	����$��../Assets/Fonts/#iconfont)�$��20(�$��Center=�$��Center=����#DDD�� $ PART_ContentHost��$��1��|�.  $��Hidden=�$��Hidden=�$��Center=�$��20��
 P�  � {� .  . ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��# [  � ��P�  �@J�IsKeyboardFocused . . ��� $ border��# [  � �� ]�  �� + �@G�#IsInactiveSelectionHighlightEnabled . ��  �@G�IsSelectionActive .  ./���  �@G�SelectionBrush# � /��� VaildationCodeTextBoxStyle  " ��.���  � ��# � ����  � ��# [ ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ border��#��z��#��z��#��z�� . $	 5��._��  �� $��40 ��� �� $��80 �.+��� $	����$��../Assets/Fonts/#iconfont)�$��20(�$��Center=�$��Center=����#DDD�� $ PART_ContentHost��$��1��|�.  $��Hidden=�$��Hidden=�$��Center=�$��20��
 P�  � {� .  . ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��# [  � ��P�  �@J�IsKeyboardFocused . . ��� $ border��# [  � �� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush# � /�%    .���� $��5q�
�������$	 10�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$
 Gray��   ShadowDepth$ 0Q�   
BlurRadius$ 5Q�   Opacity$	 0.3Q�   	Direction$ 0Q�._��   � RowDefinitions  �� $	��180 ��� $	��300 �.+��� -   ���#007DFA$	 	10,10,0,0���� $	��Top=�$��Right=�  WindowControlButtonStyle#��[ $	�������� *CloseWindowCommand+���� ! �� ElementName$! window���� $��Bottom=�$��0,0,0,30q�.+��� 
�������$��Center=�$��Center=�$	 50��$��0,0,0,20q�._��� $��80��$��80������ " �� ImageSource$#" ../Assets/images/tengfeng.jpg���� $��腾峰教育��$��Center=�
�������$��18(�� $��1��$��20q�# +� FocusedElement# �� $! txtUserName��  �� $��80 ��� $��80 ��� $��80 ��� $
��auto �.+��� -   $��txtUserName��$��40��$��16(����#555  UserNametext#���  ���� *LoginModel.UserName+.��G� $��1��$��40��  PasswordBoxStyle#���  $��16(����#555    kobe.Common.PasswordHelper$   Attach$ . %   Password% �� *LoginModel.Password+& �� Mode$& TwoWay=�' �� UpdateSourceTrigger$' PropertyChanged=��� $��
登    录��$��2��$��40��
�������$��16(�  LoginButtonTemplate#��[ ���� *LoginCommand+���� $! window���� 
���  ��$��3��$��40��$��13(�$��Center=����� *ErrorMessage+�� 
������ $��1��$��2��y��� *ShowProgress+._�� $	��Top=�$��3��( � IsIndeterminate( . 
��� ���
������ $��0q�