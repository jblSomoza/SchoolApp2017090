   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   K GSchoolApp2017090, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SchoolApp2017090SchoolApp2017090 5   	   +   %SchoolApp2017090.CourseInstructorView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   0localclr-namespace:SchoolApp2017090     5   	     � Title$  CourseInstructorView��5	   	   $	��405��6&   $	��530��63   .��5
      � .+�5   
   �� $��	Course ID��6   $
��Left=�6$   $��	13,18,0,0q�6?   $	��Top=�6R   �� 5   
   $��	Person ID��6   $
��Left=�6$   $��	13,64,0,0q�6?   $	��Top=�6R   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6h   $��
340,22,0,0q�6�   $	��Top=�6�   $	��160��6�   ��6%   �� *
ListCourse+ �� SelectedItem 6H   �� *Course+��5      �� 5      .R�5      �� ��6    �� *
CourseID+5      5      �� 5   
   $
��Left=�6V   $��
340,68,0,0q�6q   $	��Top=�6�   $	��160��6�   ��6   �� *
ListPerson+ 66   �� *Person+��5      �� 5      .R�5      �� ��6    �� *
PersonID+5      5      �� 5   
   $
��Left=�6   $��10,125,0,96q�60   $	��503��6E   .+�5      &   System.Windows.Controls.DataGrid     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6      AutoGenerateColumns .     CanUserResizeColumns .     CanUserResizeRows .  $   HorizontalScrollBarVisibility$ Visible=�6�   "   VerticalScrollBarVisibility$ Visible=�6�   ��6z   �� *ListCourseInstructor+ 6�   �� *	Element+	   Columns	 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Course ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
CourseID+  5"      $
 	Person ID��6)    6<   �� *
PersonID+5$      5%      �� 5'   
   -   5         ��Name$ btnNew��5'      $	��New��6!   $	��new��6L   $
��Left=�6}   $��
13,321,0,0q�6�   $	��Top=�6�   $��75��6�      AccentedSquareButtonStyle#��[  6�   {�6/   �� *BtnNew+��6c   �� *Model+6�   �� 5(   
   -   5        $ btnSave��5(      $
��Save��6"   $
��save��6O   $
��Left=�6�   $��107,321,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�61   �� *	BtnSave+��6g   �� *Model+6�   �� 5)   
   -   5        $ 	btnDelete��5)      $��Delete��6$   $��delete��6T   $
��Left=�6�   $��200,321,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�    �� IsCancel 65   �� *	BtnDelete+��6n   �� *Model+6�   �� 5*   
   -   5        $ 	btnCancel��5*      $��Cancel��6$   $��cancel��6U   $
��Left=�6�   $��300,321,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�65   �� *	BtnCancel+��6o   �� *Model+6�   5+      5,      