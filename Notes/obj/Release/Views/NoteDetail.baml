   M S B A M L   `   `   `  ���� @  <Notes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Notes.ViewsNotes.Views  1clr-namespace:Notes.ResourcesNotes.Resources  A =Domain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:Domain;assembly=DomainDomain     Notes.Views.NoteDetail   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:Notes.Views     3	resourcesclr-namespace:Notes.Resources     7Domain$clr-namespace:Domain;assembly=Domain     -     � Title$
  Note��$	��245��$	��413�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�   DarkGrey#���    � WindowStartupLocation$ CenterScreen=�$��1,0,1,1q�  Blue#���   � DataContext   Domain.Note  .���  � RowDefinitions �� $
��Auto ��� .+�   Notes.Resources.TopBar  -     Name$ TopBar��$��0��$
��Auto���� $��1,0,1,1q�$��1��._�� $��
10,10,10,0q� �� $
��Auto ��� �� $
��Auto �.+��� $��0��.+��� $��Titulo��$
��Bold"�#���  �� -    ��Name$ TxtTitle��$��1q� �� MaxLines$ 1��#���  $	��2,0q�
����������� *Title+	 �� 
CaretBrush	 Z� � $��1�� �� $
��Auto ��� .+��� $��0��$
��Nota��$��0,10,0,0q�$
��Bold"�#���  �� -   $ TxtBody��$��1��$��0q�$��1q�#���  $��2,0,2,2q�
����������� *Body+	 Z� �� 
 �� Orientation$
 
Horizontal=�$��2��$��Right=�$��0,5,5,10q�.+��� -    ��Name$ BtnSave��$��Guardar��$��30��$��0 0 10 0q�#���  
���������Z� �� -   $ 	BtnCancel��$��Cancelar��$��30��$��0q�#���  
���������Z� 