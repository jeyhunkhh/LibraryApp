   M S B A M L   `   `   `  ����E  ALibraryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LibraryApp.WindowsLibraryApp.Windows  5   	   $    LibraryApp.Windows.BooksWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LibraryApp.Windows     5   	     � Title$  Kitablar��5   	   $	��550��6   $
��1000��6'    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ CanMinimize=�6Y   .��5	      � .+�5
   
   � $��	0,0,745,0q�6   .+�5      �� -   5         ��Name$ LblBookName��5      $��Kitabın adı��6)   $��
38,10,37,0q�6?   $	��Top=�6S   $��14(�6k   $
��Bold"�6y   �� 5      -   5         ��Name$ TxtBookName��5      $��
38,42,37,0q�6+    �� TextWrapping$
 Wrap=�6?   $	��Top=�6S   �� 5      -   5        $ LblBookAuthor��5      $��Kitabın yazarı��6+   $��
38,85,37,0q�6D   $	��Top=�6X   $��14(�6p   $
��Bold"�6~   �� 5      -   5        $ TxtBookAuthor��5      $��38,117,37,0q�6-   $
 Wrap=�6B   $	��Top=�6V   �� 5      -   5        $ LblBookPrice��5      $��Hətfəlik qiyməti-₼��6*   $��38,160,37,0q�6G   $	��Top=�6\   $��14(�6t   $
��Bold"�6�   �� 5      -   5        $ TxtBookPrice��5      $��38,192,37,0q�6,   $
 Wrap=�6A   $	��Top=�6U   �� 5      -   5        $ LblBookCount��5      $��Kitab sayı��6*   $��38,233,37,0q�6?   $	��Top=�6T   $��14(�6l   $
��Bold"�6z   �� 5      -   5        $ TxtBookCount��5      $��38,265,37,0q�6,   $
 Wrap=�6A   $	��Top=�6U   �� 5      -	   5        $ LblBookShelf��5      $��Kitab dolabı��6*   $��38,309,37,0q�6A   $	��Top=�6V   $��14(�6n   $
��Bold"�6|   �� 5      -
   5        $ TxtBookShelf��5      $��38,341,37,0q�6,   $
 Wrap=�6A   $	��Top=�6U   �� 5      -   5         ��Name$ BtnBookCreate��5      $��Kitab əlavə et��6,   $��38,388,37,0q�6E   $	��Top=�6Z   6r   �� 5      -   5        $ BtnBookDelete��5      $	��Sil��6,   $��38,440,37,0q�6:   $	��Top=�6O   $y�Hidden=�6g   6{   �� 5      -   5        $ BtnBookUpdate��5      $��Yenilə��6,   $��38,388,37,0q�6=   $	��Top=�6R   $y�Hidden=�6j   6~   5      � 5   
   $��	255,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DgBooks��5         AutoGenerateColumns$ False��6(   	   CanUserAddRows$	 False��6D   
   
IsReadOnly$

 True��6[      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $ 0.20* 6)   $ 
Kitab adı��67    6J   �� *Name+  5      $ 0.20* 6)   $ Yazar��67    6F   �� *Author+  5      $ 0.10* 6)   $ Qiymət��67    6G   �� *	WeekPrice+  5       $ 0.10* 6)   $ Sayı��67    6E   �� *Count+  5!      $ 0.10* 6)   $ Dolabı��67    6G   �� *	BookShelf+5$      5&      5'      5(      