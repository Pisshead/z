   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5           WpfApp1.FirstWPFReportPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  FirstWPF - View List��5	      .��5      �  � 	Resources 5   
      typeItemTemplate �� XPath  amountItemTemplate��%�   &	        &	 F     �� 5      .R�5      �� ��6   �� $ 	@LastName��5      �� 5      .R�5      �� ��6   �� $ 	@Location��5      5      ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5       $	��230 �6   �� 5!       � RowDefinitions 5#   
   �� 5$      $
��Auto �6   �� 5%      .+�5'   
   �� $��1��6     headerTextStyle#��[ 6    .��6I   Address Report For:5)      � 5*   
   $��10q�6   $��1��6   $��1��6+    5+      �� 5,      �� 5-       5/      �� 50      $
��Auto �6    �� 51      $
��Auto �6    �� 52      .+�58      �� $��0��6   $��2��6)   $��0��6=    �� Orientation$ 
Horizontal=�6J   .+�59      ��   
labelStyle#��[ 6   .��6<   First Name:6I   �� 5:      #��[ 6   ��6<   �� $ 
@FirstName��6c   5;      �� 5>      $��0��6   $��2��6)   $��1��6=   $ 
Horizontal=�6J   .+�5?      �� #��[ 6   .��6<   	Location:6G   �� 5@      #��[ 6   ��6<   �� $ 	@Location��6b   5A      � 5E      $��0��6   $��2��6#   $��2��67   $	��Top=�6D   $
��Left=�5F      .+�5J      &   System.Windows.Controls.DataGrid    columnHeaderStyle   ColumnHeaderStyle# [ 6A      AutoGenerateColumns .  	   RowHeaderWidth$	 0Q�6�   ��6   �� $ Address��
   Columns
 5L      0  *System.Windows.Controls.DataGridTextColumn  5M      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Last Name��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� $ 	@LastName��  5N      $ Function��6-    6?   �� $ 	@Function��5Q      5R      5S      5T      5U      