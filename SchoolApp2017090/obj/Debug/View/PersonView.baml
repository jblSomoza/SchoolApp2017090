   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   K GSchoolApp2017090, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SchoolApp2017090SchoolApp2017090 5   	   !   SchoolApp2017090.PersonView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   0localclr-namespace:SchoolApp2017090     5   	     � Title$  
PersonView��5	   	   $	��425��6   $	��530��6)   .��5
      � .+�5   
   �� $��	Person ID��6   $
��Left=�6$   $��	13,10,0,0q�6?   $	��Top=�6R   �� 5   
   $��	Last Name��6   $
��Left=�6$   $��	13,41,0,0q�6?   $	��Top=�6R   �� 5   
   $��
First Name��6   $
��Left=�6%   $��	13,73,0,0q�6@   $	��Top=�6S   �� 5   
   $��HireDate��6   $
��Left=�6#   $��
13,104,0,0q�6>   $	��Top=�6R   �� 5   
   $��Enrollment Date��6   $
��Left=�6*   $��
13,135,0,0q�6E   $	��Top=�6Y   �� 5   
   -   5         ��Name$ txtPersonID��5      $
��Left=�6A   $��23��6\   $��
363,13,0,0q�6h   $	��Top=�6|   $	��120��6�   ��6'   �� *
PersonID+6�   �� 5   
   -   5        $ txtLastName��5      $
��Left=�6A   $��23��6\   $��
363,44,0,0q�6h    �� TextWrapping$
 Wrap=�6|   $	��Top=�6�   $	��120��6�   ��6'   �� *
LastName+6�   �� 5   
   -   5        $ txtFirstName��5      $
��Left=�6C   $��23��6^   $��
363,76,0,0q�6j   $
 Wrap=�6~   $	��Top=�6�   $	��120��6�   ��6(   �� *	FirstName+6�   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��363,106,0,0q�6S   $	��Top=�6h   $	��120��6�      SelectedDate 60   �� *
HireDate+6�     5   
   $
��Left=�6   $��363,137,0,0q�6X   $	��Top=�6m   $	��120��6�    60   �� *EnrollmentDate+6�   �� 5   
   $
��Left=�6   $��10,175,0,46q�60   $	��503��6E   .+�5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 63      CanUserResizeColumns .     CanUserResizeRows .     AzureDataGrid#��[  6�   ��6z   �� *
ListPerson+ �� SelectedItem 6�   �� *	Element+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Person ID��6)      Width$	 100 6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *
PersonID+  5      $
 	Last Name��6)   $	 100 6<    6H   �� *
LastName+  5      $
 
First Name��6)   $	 100 6=    6I   �� *	FirstName+  5      $
 	Hire Date��6)   $	 100 6<    6H   �� *
HireDate+  5      $
 Enrollment Date��6)   $	 100 6B    6N   �� *EnrollmentDate+5       5!      �� 5"   
   -   5         ��Name$ btnNew��5"      $	��New��6!   $	��new��6f   $
��Left=�6}   $��
10,361,0,0q�6�   $	��Top=�6�   $��75��6�     AccentedSquareButtonStyle#��[ 6�   {�6/   �� *BtnNew+��6L   �� *Model+6�   �� 5#   
   -   5        $ btnSave��5#      $
��Save��6"   $
��save��6i   $
��Left=�6�   $��106,361,0,0q�6�   $	��Top=�6�   $��75��6�   #��[ 6�   {�61   �� *	BtnSave+��6O   �� *Model+6�   �� 5$   
   -   5        $ 	btnDelete��5$      $��Delete��6$   $��delete��6o   $
��Left=�6�   $��200,361,0,0q�6�   $	��Top=�6�   $��75��6�   #��[ 6�   {�65   �� *	BtnDelete+��6U   �� *Model+6�   �� 5%   
   -   5        $ 	btnCancel��5%      $��Cancel��6$   $��cancel��6o   $
��Left=�6�   $��298,361,0,0q�6�   $	��Top=�6�   $��75��6�   #��[ 6�   {�65   �� *	BtnCancel+��6U   �� *Model+6�   �� 5&   
   -   5        $ 	btnUpdate��5&      $��Update��6$   $��update��6o   $
��Left=�6�   $��400,361,0,0q�6�   $	��Top=�6�   $��75��6�   #��[ 6�   {�65   �� *	BtnUpdate+��6U   �� *Model+6�   5'      5(      