   M S B A M L   `   `   `  ����@  <Notes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NotesNotes  5   	   1clr-namespace:Notes.ResourcesNotes.Resources  6+   A =Domain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:Domain;assembly=DomainDomain 5   	       Notes.MainWindow   5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Notes     5   	   3	resourcesclr-namespace:Notes.Resources     6+   7Domain$clr-namespace:Domain;assembly=Domain     5   	   -   5          � Title$  My Notes��5
   	   $	��600��6   $	��950��6'      DarkGrey#���   63    � WindowStyle$
 None=�6[    � 
ResizeMode$ NoResize=�6n    � WindowStartupLocation$ CenterScreen=�6�     Blue#���  6�   $��1,0,1,1q�6�    � DataContext 5        Domain.User  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
      Notes.Resources.TopBar  -   5          Name$ TopBar��5      $��0��6+   $��25��68   � 5   
   $��1��6   #���   6    � ColumnDefinitions 5      �� 5      �� 5      $
��Auto �6#   .+�5      �� $��0��6   $��2��6$   $	��0,5q�6Q   $��Center=�6^   ���	#DDFFFFFF$
��Bold"�6�   $��14(�6�   $��25��6�   ��68   �� *Name+6�   �� 5      -   5         ��Name$ 	BtnLogOut��5      $��1��6(   $
��Auto��68   $��0q�6F   $��0,0,10,0q�6R   ���	#00DDDDDD���	#00707070.��5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Logout=�6+   $��30��69   $��30��6D   $��Center=�6P   #���  6k   5      5      �� 5!   
   #���   6   $��1,0,1,1q�6:   $��2��6T   ._�5"      �  5#      �� 5$      �� 5%      $
��Auto �6$   .+�5(      �� -   5        
 ��Name$
 Scrolls��5(      $��0,0,0,5q�60   $��2��6W   $��Hidden=�6h   ��6A   Z� .��5)      �� -   5         ��Name$ 
StackPanel��5)   !   5*      �� 5,      -   5        $ BtnAdd��5,       & "MaterialDesignFloatingActionButton#��[ 5-      $��Right=�5/      $��40��50      $��40��51      #���  52      $��	0,5,10,10q�54      $��3��55      
���������5.      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$	 Add=���53      Z� 55   7   57      58      5@      5A      