   M S B A M L   `   `   `  ����@  <Notes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Notes.ViewsNotes.Views  5   	   1clr-namespace:Notes.ResourcesNotes.Resources  61   A =Domain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:Domain;assembly=DomainDomain 5   	       Notes.Views.NoteDetail   5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Notes.Views     5   	   3	resourcesclr-namespace:Notes.Resources     61   7Domain$clr-namespace:Domain;assembly=Domain     5   	   -   5          � Title$
  Note��5
   	   $	��245��6   $	��413��6#    � 
ResizeMode$ NoResize=�6/    � WindowStyle$
 None=�6E      DarkGrey#���   6X    � WindowStartupLocation$ CenterScreen=�6�   $��1,0,1,1q�6�     Blue#���  6�    � DataContext 5        Domain.Note  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
      Notes.Resources.TopBar  -   5          Name$ TopBar��5      $��0��6+   $
��Auto��68   �� 5   
   $��1,0,1,1q�6   $��1��6+   ._�5      � $��
10,10,10,0q�6    5      �� 5      $
��Auto �6$   �� 5      �� 5      $
��Auto �6$   .+�5      �� $��0��6   .+�5      �� $��Titulo��6   $
��Bold"�6-   #���  6?   �� 5      -   5         ��Name$ TxtTitle��5      $��1q�61    �� MaxLines$ 1��6\   #���  6i   $	��2,0q�6�   
���������6E   �� *Title+	 �� 
CaretBrush	 6�   Z� 6�   5      � 5!      $��1��6    5"      �� 5#      $
��Auto �6(   �� 5$      .+�5&      �� $��0��6   $
��Nota��6)   $��0,10,0,0q�68   $
��Bold"�6J   #���  6\   �� 5'      -   5        $ TxtBody��5'      $��1��6/   $��0q�6<   $��1q�6G   #���  6[   $��2,0,2,2q�6�   
���������6�   �� *Body+	 6�   Z� 6�   5(      �� 5+      
 �� Orientation$
 
Horizontal=�6   $��2��66   $��Right=�6C   $��0,5,5,10q�6_   .+�5,      �� -   5         ��Name$ BtnSave��5,      $��Guardar��6.   $��30��6@   $��0 0 10 0q�6L   #���  6^   
���������6�   Z� 6�   �� 5-      -   5        $ 	BtnCancel��5-      $��Cancelar��60   $��30��6C   $��0q�6O   #���  6Z   
���������6~   Z� 6�   5.      50      51      53      54      