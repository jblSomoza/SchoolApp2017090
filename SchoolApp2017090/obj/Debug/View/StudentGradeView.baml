   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   K GSchoolApp2017090, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SchoolApp2017090SchoolApp2017090 5   	   '   !SchoolApp2017090.StudentGradeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SchoolApp2017090     5   	     � Title$  StudentGradeView��5	   	   $	��425��6"   $	��525��6/   .��5      � .+�5   
   �� $��Enrollment ID��6   $
��Left=�6(   $��	13,10,0,0q�6C   $	��Top=�6V   �� 5   
   $��	Course ID��6   $
��Left=�6$   $��	13,41,0,0q�6?   $	��Top=�6R   �� 5   
   $��
Student ID��6   $
��Left=�6%   $��	13,73,0,0q�6@   $	��Top=�6S   �� 5   
   $��Grade��6   $
��Left=�6    $��
13,104,0,0q�6;   $	��Top=�6O   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $��
363,41,0,0q�6@   $	��Top=�6T   $	��120��6l   ��6x   �� *
ListCourse+ �� SelectedItem 6�   �� *Course+��5      �� 5      .R�5      �� ��6    �� *
CourseID+5      5      �� 5   
   -   5         ��Name$ txtEnrollmentID��5      $
��Left=�6I   $��23��6d   $��
363,13,0,0q�6p   $	��Top=�6�   $	��120��6�   ��6+   �� *EnrollmentID+6�   �� 5   
   -   5        $ txtStudentID��5      $
��Left=�6C   $��23��6^   $��
363,76,0,0q�6j    �� TextWrapping$
 Wrap=�6~   $	��Top=�6�   $	��120��6�   ��6(   �� *	StudentID+6�   �� 5   
   -   5        $ txtGrade��5      $
��Left=�6;   $��23��6V   $��363,107,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $	��120��6�   ��6$   �� *Grade+6�   �� 5   
   $
��Left=�6   $��10,175,0,46q�60   $	��503��6E   .+�5      &   System.Windows.Controls.DataGrid     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6      AutoGenerateColumns .  ��6C   �� *ListStudentGrade+ 6l   �� *	Element+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Enrollment ID��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6@   �� *EnrollmentID+  5!      $ 	Course ID��6)   	 6<   �� *
CourseID+  5"      $ 
Student ID��6)   	 6=   �� *	StudentID+  5#      $ Grade��6)   	 68   �� *Grade+5%      5&      �� 5(   
   -   5        
 ��Name$
 btnNew��5(      $	��New��6!   $	��new��6L   $
��Left=�6}   $��
10,361,0,0q�6�   $	��Top=�6�   $��75��6�      AccentedSquareButtonStyle#��[  6�   {�6/   �� *BtnNew+��6c   �� *Model+6�   �� 5)   
   -   5        $
 btnSave��5)      $
��Save��6"   $
��save��6O   $
��Left=�6�   $��106,361,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�61   �� *	BtnSave+��6g   �� *Model+6�   �� 5*   
   -   5        $
 	btnDelete��5*      $��Delete��6$   $��delete��6U   $
��Left=�6�   $��200,361,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�65   �� *	BtnDelete+��6o   �� *Model+6�   �� 5+   
   -   5        $
 	btnCancel��5+      $��Cancel��6$   $��cancel��6U   $
��Left=�6�   $��298,361,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�65   �� *	BtnCancel+��6o   �� *Model+6�   �� 5,   
   -	   5        $
 	btnUpdate��5,      $��Update��6$   $��update��6U   $
��Left=�6�   $��400,361,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�65   �� *	BtnUpdate+��6o   �� *Model+6�   5-      50      