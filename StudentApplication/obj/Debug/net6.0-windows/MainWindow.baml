   M S B A M L   `   `   `  ����M  IStudentApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:StudentApplicationStudentApplication  5   	   #    StudentApplication.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:StudentApplication     5   	   c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	     � Title$  
MainWindow��5	   	   $	��600��6   $	��920��6)   
������  � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � -   5        .+�5   
   �� ���#33334c �� CornerRadius$ 20��6&   ._�5      �  � ColumnDefinitions 5      �� 5      $	��400 �6'   �� 5       � RowDefinitions 5      �� 5      $	��200 �6$   �� 5      .+�5      �� $��1��6   $��Right=�6-   $	��Top=�6I   .+�5      �� -   5         ��Name$ btn_Exit��5   C   $��10 20 q�5       &  "MaterialDesignFloatingActionButton#��[  6-   	 � ToolTip$	 Close��5   3   ��6   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Close=�62   
���   �$��30��6R   $��30��6]   5      5       � 5!      $��1��6   $��1��6%   
������ .+�5"      ��  �� Orientation$ 
Horizontal=�6!   $��50q�6:   .+�5#      �� $ Vertical=�6%   .+�5$      �� 
������ $��EMAIL :��6?   
�������$��0q�5%   &   $��18(�6:   $��Center=�6H   $��	40,25,4,0q�6c   �� 5&      
������ $��
PASSWORD :��6?   
�������$��0q�5'   &   $��18(�6:   $��Center=�6H   $��0,23,4,0q�6c   5(      �� 5)      $��1��6%   $ Vertical=�65   .+�5*      �� $��10q�6%   $ 10��62   $	��200��6D   $��50��6P   ���#28283c._�5+   "   � .+�5,   &   �� $��1��60   �� 5-   &   -   5         ��Name$ txtStudentEmail��5-   .   $��1q�6G   $��18(�6R   $��0q�5.   .   
������ $��Center=�6[   $��5q�5/   .   
�������6:   50   #   51      G� 52      -   5         G�Name$ txtPassword��52   *   
�������6?   �� 53      $��80��6%   $��40��60   ���#28283c$��10q�6Q   $ 10��6]   ._�54   "   �� -   5        $ BtnLogin��55   K   $��LOGIN��54   )   
�������
������ $��17(�55   )   $��0q�67   6]   56      57      58      59      �� 5:      $ 
Horizontal=�6   .+�5;      �� $	��-30q�6   $	��398��6*   $	��250��66   ���#a5d5ff$	 500��6X   ._�5<      �� $��Welcome in SWT School��6$   $��Center=�6A   $
��Left=�5=   $   
�������$��32(�6R   $��35,0,0,0q�6`   5>      5?      �� 5@      $��1��6   .+�5A      �� $C��=https://www.mystudentplan.ca/_images/student-plan-landing.png��6   5B      �� 5C      $��1��6   $��1��6)   $��0,0,-500,-450q�66   $	��508��6M   $	��250��6Y   ���#a5d5ff$	 500��5D   .   5E      5F      5G      5H      