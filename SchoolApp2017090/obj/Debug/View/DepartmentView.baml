   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   K GSchoolApp2017090, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SchoolApp2017090SchoolApp2017090 5   	   %   SchoolApp2017090.DepartmentView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   0localclr-namespace:SchoolApp2017090     5   	     � Title$  DepartmentView��5	   	   $	��425��6    $	��530��6-   .��5
      � $��0,0,2,0q�6   .+�5   
   �� $��Department ID��6   $
��Left=�6(   $��	10,10,0,0q�6C   $	��Top=�6V   �� 5   
   $
��Name��6   $
��Left=�6   $��	10,41,0,0q�6:   $	��Top=�6M   �� 5   
   $��Budget��6   $
��Left=�6!   $��	10,72,0,0q�6<   $	��Top=�6O   �� 5   
   $��	StartData��6   $
��Left=�6$   $��
10,103,0,0q�6?   $	��Top=�6S   �� 5   
   $��Administrator��6   $
��Left=�6(   $��
10,134,0,0q�6C   $	��Top=�6W   �� 5   
   -   5         ��Name$ txtDepartmentID��5      $
��Left=�6I   $��23��6d   $��
327,14,0,0q�6p    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��145��6�   ��6+   �� *DepartmentID+6�   �� 5   
   -   5        $ txtName��5      $
��Left=�69   $��23��6T   $��
327,45,0,0q�6`   $
 Wrap=�6t   $	��Top=�6�   $	��145��6�   ��6#   �� *Name+6�   �� 5   
   -   5        $ 	txtBudget��5      $
��Left=�6=   $��23��6X   $��
327,76,0,0q�6d   $
 Wrap=�6x   $	��Top=�6�   $	��145��6�   ��6%   �� *Budget+6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ txtStartData��5      $
��Left=�6N   $��327,104,0,0q�6i   $	��Top=�6~   $	��145��6�      SelectedDate 6+   �� *	StartDate+6�   �� 5   
   -   5        $ txtAdministrator��5      $
��Left=�6K   $��23��6f   $��327,138,0,0q�6r   $
 Wrap=�6�   $	��Top=�6�   $	��145��6�   ��6,   �� *Administrator+6�   �� 5   
   $
��Left=�6   $��10,176,0,53q�60   $	��503��6E   .+�5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .  "   VerticalScrollBarVisibility$ Visible=�6{   $   HorizontalScrollBarVisibility$ Visible=�6�   $	��164��6�   ��6   �� *ListDepartment+ �� SelectedItem 6Z   �� *	Element+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 DepartmentID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 99 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *DepartmentID+6`     5      $

 Name��6)   $	 100 6P    67   �� *Name+6P     5      $
 Budget��6)   $	 100 6T    69   �� *Budget+6T     5      $
 	StartDate��6)   $	 100 6Z    6<   �� *	StartDate+6Z     5      $
 Administrator��6)   $	 100 6b    6@   �� *Administrator+6b   5       5!      �� 5#   
   -   5         ��Name$ btnNew��5#      $	��New��6!   $	��new��6L   $
��Left=�6}   $��
18,354,0,0q�6�   $	��Top=�6�   $��75��6�   $��19��6�      AccentedSquareButtonStyle#��[  6�   {�6/   �� *BtnNew+��6c   �� *Model+6�   �� 5$   
   -   5        $ btnSave��5$      $
��Save��6"   $
��save��6O   $
��Left=�6�   $��110,354,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�61   �� *	BtnSave+��6g   �� *Model+6�   �� 5%   
   -   5        $ 	btnDelete��5%      $��Delete��6$   $��delete��6U   $
��Left=�6�   $��204,354,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�65   �� *	BtnDelete+��6o   �� *Model+6�   �� 5&   
   -	   5        $ 	btnCancel��5&      $��Cancel��6$   $��cancel��6U   $
��Left=�6�   $��298,354,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�65   �� *	BtnCancel+��6o   �� *Model+6�   �� 5'   
   -
   5        $ 	btnUpdate��5'      $��Update��6$   $��update��6U   $
��Left=�6�   $��397,354,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�65   �� *	BtnUpdate+��6o   �� *Model+6�   5(      5)      