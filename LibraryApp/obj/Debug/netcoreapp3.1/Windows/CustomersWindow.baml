   M S B A M L   `   `   `  ����E  ALibraryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LibraryApp.WindowsLibraryApp.Windows  5   	   (    "LibraryApp.Windows.CustomersWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LibraryApp.Windows     5   	     � Title$  Müştərilər��5   	   $	��500��6   $
��1000��6)    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ CanMinimize=�6[   .��5	      � .+�5
   
   � $��	0,0,732,0q�6   .+�5      �� -   5         ��Name$ LblCustomerName��5      $��Ad��6-   $��
38,20,37,0q�6:   $	��Top=�6N   $��14(�6f   $
��Bold"�6t   �� 5      -   5         ��Name$ TxtCustomerName��5      $��
38,52,37,0q�6/    �� TextWrapping$
 Wrap=�6C   $	��Top=�6W   �� 5      -   5        $ LblCustomerSurname��5      $��Soyad��60   $��
38,93,37,0q�6@   $	��Top=�6T   $��14(�6l   $
��Bold"�6z   �� 5      -   5        $ TxtCustomerSurname��5      $��38,125,37,0q�62   $
 Wrap=�6G   $	��Top=�6[   �� 5      -   5        $ LblCustomerPhone��5      $��Telefon nömrəsi��6.   $��38,166,37,0q�6H   $	��Top=�6]   $��14(�6u   $
��Bold"�6�   �� 5      -   5        $ TxtCustomerPhone��5      $��38,198,37,0q�60   $
 Wrap=�6E   $	��Top=�6Y   �� 5      -   5        $ LblBirthday��5      $��Doğum tarixi :��6)   $��38,242,37,0q�6B   $	��Top=�6W   $��14(�6o   $
��Bold"�6}   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DtpBirthday��5      $
��Left=�6.   $��142,242,0,0q�6I   $	��Top=�6^   �� 5      -	   5         ��Name$ 	BtnCreate��5      $��Müştəri əlavə et��6(   $��38,304,37,0q�6C   $	��Top=�6X   6p   �� 5      -
   5        $ 	BtnUpdate��5      $��Yenilə��6(   $��38,304,37,0q�69   $	��Top=�6N   $y�Hidden=�6f   6z   �� 5      -   5        $ 	BtnDelete��5      $	��Sil��6(   $��38,363,37,0q�66   $	��Top=�6K   $y�Hidden=�6c   6w   5      � 5   
   $��	268,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DgCustomers��5      	   AutoGenerateColumns$	 False��6,   
   CanUserAddRows$
 False��6H      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $ 0.25* 6)   $ Ad��67    6C   �� *Name+  5      $ 0.25* 6)   $ Soyad��67    6F   �� *	Surname+  5      $ 0.20* 6)   $ Doğum günü��67    6K   �� *
Birthday+ �� StringFormat$ {0:dd.MM.yyyy }��  5      $ 0.20* 6)   $ Nömrə��67    6F   �� *PhoneNumber+5!      5"      5#      5$      