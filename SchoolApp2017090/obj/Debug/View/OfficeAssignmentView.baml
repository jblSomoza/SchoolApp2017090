   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   K GSchoolApp2017090, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SchoolApp2017090SchoolApp2017090 5   	   +   %SchoolApp2017090.OfficeAssignmentView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   0localclr-namespace:SchoolApp2017090     5   	     � Title$  OfficeAssignmentView��5	   	   $	��400��6&   $	��525��63   .��5
      � .+�5   
   �� $��Instructor ID��6   $
��Left=�6(   $��	13,18,0,0q�6C   $	��Top=�6V   �� 5   
   $��Location��6   $
��Left=�6#   $��	14,49,0,0q�6>   $	��Top=�6Q   �� 5   
   $��	Timestamp��6   $
��Left=�6$   $��	14,81,0,0q�6?   $	��Top=�6R   �� 5   
   -   5         ��Name$ txtInstructorID��5      $
��Left=�6I   $��23��6d   $��
363,21,0,0q�6p   $	��Top=�6�   $	��120��6�   ��6+   �� *InstructorID+6�   �� 5   
   -   5        $ txtLocation��5      $
��Left=�6A   $��23��6\   $��
363,52,0,0q�6h    �� TextWrapping$
 Wrap=�6|   $	��Top=�6�   $	��120��6�   ��6'   �� *
Location+6�   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��
363,83,0,0q�6S   $	��Top=�6g   $	��120��6      SelectedDate 60   �� *	Timestamp+6   �� 5   
   $
��Left=�6   $��10,134,0,87q�60   $	��503��6E   .+�5      &   System.Windows.Controls.DataGrid     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6      AutoGenerateColumns .     CanUserResizeColumns .     CanUserResizeRows .  ��6z   �� *ListOfficeAssignment+ �� SelectedItem 6�   �� *	Element+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Instructor ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *InstructorID+  5      $
 Location��6)    6;   �� *
Location+  5      $
 	Timestamp��6)    6<   �� *	Timestamp+5      5      �� 5   
   -   5         ��Name$ btnNew��5      $	��New��6!   $	��new��6f   $
��Left=�6}   $��
14,332,0,0q�6�   $	��Top=�6�   $��75��6�      AccentedSquareButtonStyle#��[  6�   {�6/   �� *BtnNew+��6L   �� *Model+6�   �� 5   
   -   5        $ btnSave��5      $
��Save��6"   $
��save��6i   $
��Left=�6�   $��111,332,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�61   �� *	BtnSave+��6O   �� *Model+6�   �� 5   
   -   5        $ 	btnDelete��5      $��delete��6^   $��Delete��6x   $
��Left=�6�   $��202,332,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�6$   �� *	BtnDelete+��6D   �� *Model+6�   �� 5    
   -   5        $ 	btnCancel��5       $��cancel��6^   $��Cancel��6x   $
��Left=�6�   $��300,332,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�6$   �� *	BtnCancel+��6D   �� *Model+6�   �� 5!   
   -   5        $ 	btnUpdate��5!      $��update��6^   $��Update��6x   $
��Left=�6�   $��408,332,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�6$   �� *	BtnUpdate+��6D   �� *Model+6�   5"      5#      