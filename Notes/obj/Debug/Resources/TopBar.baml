   M S B A M L   `   `   `  ����@  <Notes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Notes.ResourcesNotes.Resources  5          Notes.Resources.TopBar   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Notes.Resources     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          >�Name$  TopBar1��5      $��30��5	   7   ��5
      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ #0099bc��6    � Offset$ 0Q�6+   � 5      $ #2C3E50��6   $	 0.1Q�6+   5      .��5      � -   5         �Name$ GridTop��5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   '  !MaterialDesignThemes.Wpf.PackIcon  $��0��6"      Kind$
 Edit=�62   $��26��6>   $��26��6J      Blue#���   6U   $��Center=�6y   �� 5   
   -   5         ��Name$ 
NameWindow��5      $��1��6$    	 White#���  64   $��Center=�6Y   $��Title��6t   $
��Bold"�6�   $��Century Gothic)�6�   $��14(�6�   &   System.Windows.Media.TextOptions	   TextHintingMode$	 Animated=�6�   �� 5   
   $��2��6   
 �� Orientation$
 
Horizontal=�6%   .+�5      �� -   5         ��Name$ BtnMinimize��5      $��2��6*   $	��5,0q�6:   $
��Auto��6H    � Cursor$
 Hand��6�     BtnStyle#���  6�   ��6V   Z� ��6l   Z� ��6�   Z� .��5        $ WindowMinimize=�6*   #���  5   *   $
��Auto��5   *   $
��Auto��5    *   $��0q�5!   *   5"      �� 5$      -   5        $ 
BtnRestore��5$      $��2��6)   $	��5,0q�69   $
��Auto��6G   $y�	Collapsed=�6�   $
 Hand��6�   #���  6�   ��6U   Z� ��6k   Z� ��6�   Z� .��5%        $ WindowRestore=�6*   #���  6?   $
��Auto��6d   $
��Auto��6r   $��0q�6   $
��Left=�6�   5&      �� 5(      -   5        $ BtnMaximize��5(      $��2��6*   $	��5,0q�6:   $
��Auto��6H   $
 Hand��6�   #���  6�   ��6V   Z� ��6l   Z� ��6�   Z� .��5)        $ WindowMaximize=�6*   #���  6@   $
��Auto��6e   $
��Auto��6s   $��0q�6�   5*      �� 5,      -   5        $ BtnClose��5,      $��2��6'   $	��5,0q�6N   $
��Auto��6\   $
 Hand��6�   #���  6�   ��6j   Z� ��6�   Z� ��6�   Z� .��5-        $ Close=�6*   #���  67   $
��Auto��6\   $
��Auto��6j   $��0q�6w   5.      50      51      52      