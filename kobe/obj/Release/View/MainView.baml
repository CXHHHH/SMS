   M S B A M L   `   `   `  ���� ?  ;kobe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:kobekobe  /clr-namespace:kobe.Converterkobe.Converter      kobe.View.MainView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:kobe     2	converterclr-namespace:kobe.Converter     -   $
��main��  � Title$  腾峰教育��$	��800��$
��1250��$��Microsoft YaHei)�$��
ExtraLight"�$��12(� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . ��Z�  � 	Resources  �� MergedDictionaries �� Source$   kobe.Converter.GenderConverter   Key �� 
TargetType �� Property	 �� Value
 �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName g� Duration	 W� To �� 
TargetName �� TargetProperty � ColumnDefinitions��  �� $( "../Assets/Styles/DefaultStyle.xaml?���   genderConverter  �� " 	�NavButtonStyle  .���  � ��
	 �������  � ��	 �� "
 	�.R��� $
��back��
������ $ 8��._��� #��z��$��Center=�$��Center=�$
��20,4q�$��14(� P�  �@d�	IsChecked$
 TrueY�. ��� $
 back�� � ��	 �	#44FFFFFF�� UserInfoStoryborad  .��W� $ 0:0:0.2D�$ 0X�$ tt��$ X��� CloseUserInfoStoryborad  .��W� $ 0:0:0.1D�$ tt��$ X��� "
 	�GenderRadioButtonTemplate  .R��  �� $
��auto ��� .+��� $��14��$��14��$ 7��$��1q����#007DFA
�������$	��5,0q�$��Center=�._��� $��point��$��8��$��8��$ 4�����#007DFA$y�	Collapsed=��� #��z��$��Center=�$��1�� P�  �@d�	IsChecked$
 TrueY�. ��� $ point�� � y�$	 Visible=�%
   '	�        � Triggers :�  :� RoutedEvent$ Button.Click�� :� 
SourceName$ btnUserInfo��.[���   UserInfoStoryborad#��[ :� $ Button.Click��$ BtnCloseUserInfo��.[���   CloseUserInfoStoryborad#��[ .���� $��5q�
�������$ 5�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$
 Gray��   ShadowDepth$ 0Q�   
BlurRadius$ 5Q�   Opacity$	 0.3Q�   	Direction$ 0Q�._�� .+��� -   ���#007DFA$	��200��$	��Top=�$ 5,5,0,0����  �� Orientation$ 
Horizontal=�$	��Top=�$��Right=�.+��� -     WindowControlButtonStyle#��[ $	������ -   #��[ $	������ -   #��[ $	����� $��50,20q� � RowDefinitions �� $��65 ��� $��35 ��� .+��� $ 
Horizontal=�$
��Left=�$��Center=�.+��� $��../Assets/images/kobe.png��$��40��$��40���� $��15,0,0,0q�.+��� $$��腾峰教育课程管理平台��
�������$��20(��� $��TENGFENG EDU�����	#88DDDDDD$��10(��� $ 
Horizontal=�$��Right=�$��Center=�.+��� $��30��$��30��$ 15������   �� ImageSource  �� *UserInfo.Avatar+�� -   $��btnUserInfo��$��Center=�
�������! � Cursor$
! Hand��$��16(�$��15,0,0,0q����� "
 ��.R��� ���� *UserInfo.UserName+�� $ 
Horizontal=�$��1��$
��Left=�$��Center=�.+�	� $��首页��  NavButtonStyle#��[ " d� 	IsChecked$
" TrueY�$��FirstPageView������ *NavChangedCommand+	� $��信息管理��#��[ $��DataPageView������ *NavChangedCommand+	� $��日常处理��#��[ $��DailyAffairPageView������ *NavChangedCommand+	� $��诚聘英才��#��[ 	� $��个人中心��#��[ �� $��2������ *MainContent+�� ���	#EE444444$��Right=�$	��240��$ 0,5,5,0��   $
 Gray��$ 0Q�$ 5Q�$	 0.3Q�$ 0Q�z�T� # T� X$	# 250Q�-   tt��._��  �� $	��230 ��� .+��� -   $��BtnCloseUserInfo��$��40��$��40��$��0q�$	����$��../Assets/Fonts/#iconfont)�$	��Top=�$
��Left=��� $��80��$	�� 80��$ 40��   $ White��$ 0Q�$ 5Q�$	 0.3Q�$ 0Q�����   �� *UserInfo.Avatar+� $��1��$
��20,0q� ��%�   '��       '	� ;     �� " ��.���  � ��
	 �������  � ��$	 14(��� " 	�.���  � ��
	 �������  � ��$	 14(� �� $��40 ��� $��40 ��� $��40 ��� $��40 �.+��� $ 
Horizontal=�$��Center=�.+��� $��	用户名���� $��10,0,0,0q����� *UserInfo.UserName+�� $ 
Horizontal=�$��1��$��Center=�.+��� $��性  别��	� $	��男��$��10,0,0,0q�  GenderRadioButtonTemplate#��[ " �� *UserInfo.Gender+  genderConverter$ �� 	Converter#$ [ % �� ConverterParameter$% 1��	� $	��女��$��10,0,0,0q�#��[ " �� *UserInfo.Gender+#$ [ $% 0��