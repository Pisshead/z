   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.FirstWPFHome   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  FirstWPF - Home��5	      .��5      � $��
10,0,10,10q�6    � 	Resources 5   
      nameItemTemplate �� XPath  AddressDataSource � XPath��%�  &	        &	 G     �� 5      .R�5      �� ��6   �� $ 
@FirstName��5      � 5      $ 	Addresses��68   .��5      ��<Addresses xmlns="">
                        <Person FirstName="Joël" Location="Bern">
                            <Address LastName="Schöni" Function="Intern" />                 
                            
                        </Person>
                        <Person FirstName="Danny" Location="Reinach">
                            <Address LastName="Allemann" Function="Head Support and Coding" />                           
                        </Person>
                        <Person Name="Markus" Location="Laufen">
                            <Address LastName="Lobsiger" Function="Coding and Support" />                           
                        </Person>                      
                    </Addresses>        5"      5#       � ColumnDefinitions 5$   
   �� 5%      $	��230 �6   �� 5&       � RowDefinitions 5)   
   �� 5*      �� 5+      $
��Auto �6   �� 5,      �� 5-      $
��Auto �6   .+�5/   
   �� $��1��6     headerTextStyle#��[ 6    .��6J   View Expense Report51      �� 53   
   $��1��6   $��1��6!     listHeaderStyle#��[ 6.   ._�54      ��   listHeaderTextStyle#��[ 6   .��6A   First Names6N   55      �� 56   
   -   5        $��peopleListBox��56      $��1��6'   $��2��67   #��[  58   
   ��57   
   ��  �� Source# [ $ Person��59      �� 5<   
   -   5        $��1��5<      $��3��6!     buttonStyle#��[ 6C   .��6h   Show6n   ��5=   
   �� 5>       �� ImageSource$ watermark.png��6   5B      5C      