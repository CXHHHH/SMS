   M S B A M L   `   `   `  ���� ?  ;kobe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kobe.View	kobe.View  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf     kobe.View.FirstPageView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:kobe.View     Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     .���   � RowDefinitions  �� $	��160 ��� $	��360 ��� .+�A�  A� Columns$ 4��.+���  �� CornerRadius$ 8��
�������$��10q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ #F2F2F2��   ShadowDepth$ 10Q�   
BlurRadius$	 105Q�   Opacity$	 0.4Q�   	Direction$	 270Q�._�� .+�#  LiveCharts.Wpf.CartesianChart  $��0,0,0,45q�&   LiveCharts.Wpf.Charts.Base.Chart	   Series	   LiveCharts.Wpf.LineSeries    LiveCharts.Wpf.Series
   Stroke
 �#FECC71   Fill �#FFF2DE   PointGeometrySize$ 0Q�   Values;  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$ 1,4,23,33,80,20    AxisX   LiveCharts.Wpf.Axis     
ShowLabels .     AxisY    .     MinValue$ 0Q�   MaxValue$	 100Q���  �� Orientation$ 
Horizontal=�$	��Top=�$
��Left=�$��15q�.+��� $��20��$��20�����#EDFAF0$ 10��._��� $	����$��../Assets/Fonts/#iconfont)����#7ADA95$��Center=�$��Center=��� $	��32%��$��Center=����#7ADA95$��5,0,0,0q��� $ 
Horizontal=�$��Bottom=�$
��15,3q�.+��� $��36��$��36�����#FFF5E9$ 20��._��� $	����$��../Assets/Fonts/#iconfont)�$��Center=�$��Center=�$��20(����#FFBC57�� $��15,0,0,0q�.+��� $��监控数据一�����#3F4C5D$��12(��� $	��32%��$
��Bold"����#3F4C5D$��16(��� $ 8��
�������$��10q�   $ #F2F2F2��$ 10Q�$	 105Q�$	 0.4Q�$	 270Q�._�� .+�  $��0,0,0,45q�	   
 �#FECC71 �#FFF2DE$ 0Q�$ 1,4,23,33,80,20     .      .  $ 0Q�$	 100Q��� $ 
Horizontal=�$	��Top=�$
��Left=�$��15q�.+��� $��20��$��20�����#EDFAF0$ 10��._��� $	����$��../Assets/Fonts/#iconfont)����#7ADA95$��Center=�$��Center=��� $	��32%��$��Center=����#7ADA95$��5,0,0,0q��� $ 
Horizontal=�$��Bottom=�$
��15,3q�.+��� $��36��$��36�����#FFF5E9$ 20��._��� $	����$��../Assets/Fonts/#iconfont)�$��Center=�$��Center=�$��20(����#FFBC57�� $��15,0,0,0q�.+��� $��监控数据一�����#3F4C5D$��12(��� $	��32%��$
��Bold"����#3F4C5D$��16(��� $ 8��
�������$��10q�   $ #F2F2F2��$ 10Q�$	 105Q�$	 0.4Q�$	 270Q�._�� .+�  $��0,0,0,45q�	   
 �#FECC71 �#FFF2DE$ 0Q�$ 1,4,23,33,80,20     .      .  $ 0Q�$	 100Q��� $ 
Horizontal=�$	��Top=�$
��Left=�$��15q�.+��� $��20��$��20�����#EDFAF0$ 10��._��� $	����$��../Assets/Fonts/#iconfont)����#7ADA95$��Center=�$��Center=��� $	��32%��$��Center=����#7ADA95$��5,0,0,0q��� $ 
Horizontal=�$��Bottom=�$
��15,3q�.+��� $��36��$��36�����#FFF5E9$ 20��._��� $	����$��../Assets/Fonts/#iconfont)�$��Center=�$��Center=�$��20(����#FFBC57�� $��15,0,0,0q�.+��� $��监控数据一�����#3F4C5D$��12(��� $	��32%��$
��Bold"����#3F4C5D$��16(��� $ 8��
�������$��10q�   $ #F2F2F2��$ 10Q�$	 105Q�$	 0.4Q�$	 270Q�._�� .+�  $��0,0,0,45q�	   
 �#FECC71 �#FFF2DE$ 0Q�$ 1,4,23,33,80,20     .      .  $ 0Q�$	 100Q��� $ 
Horizontal=�$	��Top=�$
��Left=�$��15q�.+��� $��20��$��20�����#EDFAF0$ 10��._��� $	����$��../Assets/Fonts/#iconfont)����#7ADA95$��Center=�$��Center=��� $	��32%��$��Center=����#7ADA95$��5,0,0,0q��� $ 
Horizontal=�$��Bottom=�$
��15,3q�.+��� $��36��$��36�����#FFF5E9$ 20��._��� $	����$��../Assets/Fonts/#iconfont)�$��Center=�$��Center=�$��20(����#FFBC57�� $��15,0,0,0q�.+��� $��监控数据一�����#3F4C5D$��12(��� $	��32%��$
��Bold"����#3F4C5D$��16(�