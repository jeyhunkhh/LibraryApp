   M S B A M L   `   `   `  ����E  ALibraryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LibraryApp.WindowsLibraryApp.Windows  5   	   #    LibraryApp.Windows.AdminPanel   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LibraryApp.Windows     5   	     � Title$  
AdminPanel��5   	   $	��550��6   $
��1000��6)    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ CanMinimize=�6[   .��5	      � .+�5
   
   � $��	0,0,747,0q�6   .+�5      �� -   5         ��Name$ TxtName��5      $��Center=�6'   $��0,57,0,0q�6D    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��178��6�   $�� ��6�   �� 5      -   5         ��Name$ LblName��5      $��Ad��6%   $��	0,25,37,0q�62   $	��Top=�6E   $
��Bold"�6]   $��14(�6o   $��Right=�6}   $	��178��6�   �� 5      -   5        $ 
TxtSurname��5      $��Center=�6*   $��	0,133,0,0q�6G   $
 Wrap=�6[   $	��Top=�6o   $	��178��6�   $�� ��6�   �� 5      -   5        $ 
LblSurmane��5      $��Soyad��6(   $��Center=�68   $��	0,101,0,0q�6U   $	��Top=�6h   $	��178��6�   $
��Bold"�6�   $��14(�6�   �� 5      -   5        $ TxtEmail��5      $��Center=�6(   $��	0,210,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��178��6�   $�� ��6�   �� 5      -   5        $ LblEmail��5      $��E-poçt ünvanı��6&   $��Center=�6>   $��	0,178,0,0q�6[   $	��Top=�6n   $	��178��6�   $
��Bold"�6�   $��14(�6�   �� 5      -   5        $ TxtPassword��5      $��Center=�6+   $��	0,285,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��178��6�   $�� ��6�   �� 5      -   5        $ LblPassword��5      $��Şifrə��6)   $��Center=�69   $��Center=�6V   $	��178��6q   $
��Bold"�6}   $��14(�6�   �� 5      -	   5        $ TxtPhoneNumber��5      $��Center=�6.   $��	0,359,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��178��6�   $�� ��6�   �� 5      -
   5        $ LblPhoneNumber��5      $��Telefon nömrəsi��6,   $��Center=�6F   $��	0,327,0,0q�6c   $	��Top=�6v   $	��178��6�   $
��Bold"�6�   $��14(�6�   �� 5      -   5         ��Name$ 	BtnCreate��5      $��İdarəçi Əlavə et��6(   $��Center=�6C   $��	0,416,0,0q�6`   $	��Top=�6s   $	��178��6�   6�   �� 5      -   5        $ 	BtnUpdate��5      $��Yenilə��6(   $��Center=�69   $��	0,416,0,0q�6V   $	��Top=�6i   $	��178��6�   $y�Hidden=�6�   6�   �� 5      -   5        $ 	BtnDelete��5      $	��Sil��6(   $��Center=�66   $��	0,470,0,0q�6S   $	��Top=�6f   $	��178��6~   $y�Hidden=�6�   6�   5      � 5   
   $��	253,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
DgManagers��5         AutoGenerateColumns$ False��6+   	   CanUserAddRows$	 False��6G   
   
IsReadOnly$

 True��6^      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $ 0.20* 6)   $ Ad��67    6C   �� *Name+  5      $ 0.20* 6)   $ Soyad��67    6F   �� *	Surname+  5       $ 0.35* 6)   $ E-poçt��67    6G   �� *Email+  5!      $ 0.20* 6)   $ Şifrə��67    6F   �� *
Password+  5"      $ 0.20* 6)   $ Telefon��67    6H   �� *PhoneNumber+5$      5%      5&      5'      