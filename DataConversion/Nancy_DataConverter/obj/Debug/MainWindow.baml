   M S B A M L   `   `   `  ����H  DDataConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DataConvertersDataConverters  5   	       DataConverters.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DataConverters     5   	     � Title$  
MainWindow��5   	   $��487.134��6   $��588.063��6-   .��5	      � -   5         �Name$	 dg1��5	      $
��Left=�6   $	��390��63   $��	10,31,0,0q�6@   $	��Top=�6S   $	��554��6k   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$	 dg2��5
      $
��Left=�6    $	��268��6;   $��	10,10,0,0q�6H   $	��Top=�6[   $	��498��6s      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Ref Num��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *RefNum+6A     5      $ 	Course ID��6&    5      `� 5         InstructorConverter `� 	Converter# [  6'   .1�5      ��  �� Path$ 
Department�6&   �� 5      $ Number�6&   5      5        5      $
 Name��6?    6%   �� *Name+6?     5      $ 
Instructor��6%    5      `� 5      # [  6'   .1�5      �� $ InstructorFirstName�6&   �� 5      $ InstructorLastName�6&   5      5        5       $
 Open��6%    5!      `� 5"        OpenConverter# [ 6'   .1�5#      �� $ 	ClassSize�6&   �� 5$      $ NumberofStudentsEnrolled�6&   5%      5'      5)      �� 5*   
   -   5        	 ��Name$	 add_btn��5*      $��Add New Course��6"   $
��Left=�6;   $��
29,305,0,0q�6V   $	��Top=�6j   $	��105��6�   6�   5+      5,      