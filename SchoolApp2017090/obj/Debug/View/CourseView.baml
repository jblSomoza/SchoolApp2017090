   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   K GSchoolApp2017090, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SchoolApp2017090SchoolApp2017090 5   	   !   SchoolApp2017090.CourseView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   0localclr-namespace:SchoolApp2017090     5   	     � Title$  
CourseView��5	   	   $	��425��6   $	��530��6)   .��5
      � .+�5   
   �� $��	Course ID��6   $
��Left=�6$   $��	10,10,0,0q�6?   $	��Top=�6R   �� 5   
   $��Title��6   $
��Left=�6    $��	10,41,0,0q�6;   $	��Top=�6N   �� 5   
   $��Credits��6   $
��Left=�6"   $��	10,72,0,0q�6=   $	��Top=�6P   �� 5   
   $��Department ID��6   $
��Left=�6(   $��
10,103,0,0q�6C   $	��Top=�6W   �� 5   
   -   5         ��Name$ txtCourseID��5      $
��Left=�6A   $��23��6\   $��
363,13,0,0q�6h   $	��Top=�6|   $	��120��6�   ��6'   �� *
CourseID+6�   �� 5   
   -   5        $ txtTitle��5      $
��Left=�6;   $��23��6V   $��
363,44,0,0q�6b    �� TextWrapping$
 Wrap=�6v   $	��Top=�6�   $	��120��6�   ��6$   �� *Title+6�   �� 5   
   -   5        $ 
txtCredits��5      $
��Left=�6?   $��23��6Z   $��
363,76,0,0q�6f   $
 Wrap=�6z   $	��Top=�6�   $	��120��6�   ��6&   �� *	Credits+6�   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6p   $��363,107,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6%   �� *ListDepartment+ �� SelectedItem 6L   �� *
Department+��5      �� 5      .R�5      �� ��6    �� *Name+5      5      �� 5   
   $
��Left=�6   $��10,175,0,55q�60   $	��503��6E   .+�5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .  "   VerticalScrollBarVisibility$ Visible=�6w   $   HorizontalScrollBarVisibility$ Visible=�6�   $	��164��6�   ��63   �� *
ListCourse+ 6V   �� *	Element+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn	   Header$	 	Course ID��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 120 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
CourseID+6Y     5!      $	 Title��6)   $	
 130 6R    68   �� *Title+6R     5"      $	 Credits��6)   $	
 120 6V    6:   �� *	Credits+6V     5#      $	 Department ID��6)   $	
 130 6a    6@   �� *DepartmentID+6a   5%      5&      �� 5(   
   -   5         ��Name$ btnNew��5(      $	��New��6!   $	��new��6L   $
��Left=�6}   $��
18,354,0,0q�6�   $	��Top=�6�   $��75��6�   $��19��6�      AccentedSquareButtonStyle#��[  6�   {�6/   �� *BtnNew+��6c   �� *Model+6�   �� 5)   
   -   5        $ btnSave��5)      $
��Save��6"   $
��save��6O   $
��Left=�6�   $��110,354,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�61   �� *	BtnSave+��6g   �� *Model+6�   �� 5*   
   -   5        $ 	btnDelete��5*      $��Delete��6$   $��delete��6U   $
��Left=�6�   $��204,354,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�65   �� *	BtnDelete+��6o   �� *Model+6�   �� 5+   
   -   5        $ 	btnCancel��5+      $��Cancel��6$   $��cancel��6U   $
��Left=�6�   $��298,354,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�65   �� *	BtnCancel+��6o   �� *Model+6�   �� 5,   
   -	   5        $ 	btnUpdate��5,      $��Update��6$   $��update��6U   $
��Left=�6�   $��397,354,0,0q�6�   $	��Top=�6�   $��75��6�   #��[  6�   {�65   �� *	BtnUpdate+��6o   �� *Model+6�   5-      5.      