   M S B A M L   `   `   `  ����M  IStudentApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:StudentApplicationStudentApplication  5   	   M+clr-namespace:StudentApplication.ViewModelsStudentApplication.ViewModels  5   	   T PStudentApplication.Domain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulltPclr-namespace:StudentApplication.Domain.Model;assembly=StudentApplication.DomainStudentApplication.Domain.Model 5	   	   #    StudentApplication.LoggedPage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:StudentApplication     5   	   A	viewModel+clr-namespace:StudentApplication.ViewModels     5   	   c _MaterialDesignThemes.MahApps, Version=0.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   ^modelPclr-namespace:StudentApplication.Domain.Model;assembly=StudentApplication.Domain   5	   	   $	��600��5   	   $	��920��6   
������   � AllowsTransparency$
  True��5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      3   -StudentApplication.ViewModels.LoggedViewModel  5   
   .��5      � -   5        ���#27273a � ColumnDefinitions 5   
   �� 5      $	��240 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      .+�5    
   �� $��1��6   $��Right=�6%   $	��Top=�6A   5!      �� 5#   
   $��1��6   ���#33334c6   �� 5%   
   $��1��6   $��0,20,0,0q�6"   .+�5&      	� $��	My Grades��6   $��50��6.   
�������$��24(�5'         MenuButtonDictionary#��[  6(    d� 	IsChecked$
 TrueY�6V   ��6g   �� *GradeViewCommand+	� 5(      $��My Tests��6   $��50��6-   
�������$��24(�5)      #��[  6)   ��6W   �� *TestViewCommand+	� 5*      $��
My Courses��6   $��50��6/   
�������$��24(�5+      #��[  6(   ��6V   �� *CourseViewCommand+5,      �� 5.   
   $��1��6   ���#a5d5ff6!   �� 50   
   $��1��6   $��Right=�6%   $	��Top=�6A   .+�51      �� -   5         ��Name$ btn_Exit��52   ;   $��10 20 q�51       & "MaterialDesignFloatingActionButton#��[ 6%    � ToolTip$ Close��52   +   	 � Cursor$
	 Hand��6c   ��6   Z� .��53      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Close=�6*   
���   �$��30��6J   $��30��6U   54      55      �� 57   
   $��1��6   $��1��6!   ���#E6E6E658      �� 59   
   $��Center=�6   � 5:   
   $��1��6   $��1��6   
������ 5;      �� 5<   
   $��Center=�6   $��Center=�62   .+�5=      �� $v��phttps://cdn0.iconfinder.com/data/icons/education-364/24/college-education-graduation-learning-school-cap-512.png��6   $	��120��6�   $	��170��6�   5>      �� 5@   
   $��1��6   $��1��6&   $��10q�66   ��6B   �� *CurrentView+�� 5B   
   $��1��6   $��Bottom=�6"   $	��150��6=   $��15q�6J   .+�5C      ��  �� Orientation$ 
Horizontal=�6   $��	10,0,0,10q�62   .+�5D        $

 User=�6*   $��35��66   $��35��6A   
���   �6M   �� 5E      $��15(�6@   $��10q�6N   
���������6   �� *CurrentStudentName+6Z   �� 5F      $��15(�6D   $��1,10,0,0q�6R   
���������6   �� *CurrentStudentLastName+6d   5G      �� 5H      $ 
Horizontal=�6   .+�5I      �� $��Album: ��6   $��15(�6+   $
��Bold"�69   $��0,0,10,0q�6K   
�������6]   �� 5J      $��15(�6A   
���������6   �� *CurrentStudentAlbum+6O   5K      �� 5L      $ 
Horizontal=�6   $��0,10,0,0q�62   .+�5M      �� $��Email: ��6   $��15(�6+   $
��Bold"�69   $��0,0,10,0q�6K   
�������6]   �� 5N      $��15(�6A   
���������6   �� *CurrentStudentEmail+6O   5O      5P      5Q      5R      