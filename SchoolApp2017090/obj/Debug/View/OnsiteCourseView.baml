   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   K GSchoolApp2017090, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SchoolApp2017090SchoolApp2017090 5   	   '   !SchoolApp2017090.OnsiteCourseView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   0localclr-namespace:SchoolApp2017090     5   	     � Title$  OnsiteCourseView��5	   	   $	��400��6"   $	��425��6/   .��5
      � .+�5   
   �� -   5         ��Name$ label��5      $��	Course ID��6   $
��Left=�63   $��	10,10,0,0q�6N   $	��Top=�6a   �� 5   
   -   5        $ label1��5      $��Location��6    $
��Left=�63   $��
222,10,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $ label2��5      $
��Days��6    $
��Left=�6/   $��	10,53,0,0q�6J   $	��Top=�6]   �� 5   
   -   5        $ label3��5      $
��Time��6    $
��Left=�6/   $��
222,53,0,0q�6J   $	��Top=�6^   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6i   $��	77,10,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6%   �� *
ListCourse+ �� SelectedItem 6H   �� *	Element+��5      �� 5      .R�5      �� ��6    �� *
CourseID+5      5      �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��23��6>   $��	77,54,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6�   $	��120��6�   ��6q   �� *Days+6�   �� 5   
   -   5        $ textBox1��5      $
��Left=�6$   $��23��6?   $��282,54,-10,0q�6K   $
 Wrap=�6a   $	��Top=�6�   $	��120��6�   ��6u   �� *Time+6�   �� 5   
   -   5        $ textBox2��5      $
��Left=�6$   $��23��6?   $��282,11,-10,0q�6K   $
 Wrap=�6a   $	��Top=�6�   $	��120��6�   ��6u   �� *
Location+6�   �� 5   
   $
��Left=�6   $	��209��60   $��
10,106,0,0q�6=   $	��Top=�6Q   $	��392��6i   .+�5      &   System.Windows.Controls.DataGrid  -	   5          Name$ dataGrid��5         AutoGenerateColumns .  ��6)   �� *ListOnsiteCourse+ 6R   �� *	Element+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	Course ID��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 90 6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *
CourseID+  5      $	 Location��6)   $	
 105 6;    6G   �� *
Location+  5       $
	 Days��6)   $	
 105 67    6C   �� *Days+  5!      $
	 Time��6)   $	
 100 67    6C   �� *Time+5#      5$      �� 5%   
   $	��New��6   $	��new��6   $
��Left=�6p   $��
12,329,0,0q�6�   $	��Top=�6�   $��64��6�      AccentedSquareButtonStyle#��[  6�   {�67   �� *BtnNew+��6V   �� *Model+6�   �� 5&   
   $
��Save��6   $
��save��6    $
��Left=�6r   $��
81,329,0,0q�6�   $	��Top=�6�   $��56��6�   #��[  6�   {�69   �� *	BtnSave+��6X   �� *Model+6�   �� 5'   
   $��Delete��6   $��delete��6"   $
��Left=�6x   $��144,329,0,0q�6�   $	��Top=�6�   $��53��6�   #��[  6�   {�6=   �� *	BtnDelete+��6^   �� *Model+6�   �� 5(   
   $��Update��6   $��update��6"   $
��Left=�6x   $��202,329,0,0q�6�   $	��Top=�6�   $��52��6�   #��[  6�   {�6=   �� *	BtnUpdate+��6^   �� *Model+6�   �� 5)   
   $��Cancel��6   $��cancel��6"   $
��Left=�6x   $��259,329,0,0q�6�   $	��Top=�6�   $��55��6�   #��[  6�   {�6=   �� *	BtnCancel+��6^   �� *Model+6�   5*      5+      