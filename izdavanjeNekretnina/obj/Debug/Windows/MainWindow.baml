   M S B A M L   `   `   `  ����N  JizdavanjeNekretnina, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:izdavanjeNekretninaizdavanjeNekretnina  5   	   $    izdavanjeNekretnina.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:izdavanjeNekretnina     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ 	CanResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $	��550��5   	   $
��1000��6   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   � -   5        ���#575759.+�5      �� $	��Top=�6    �� Orientation$ 
Horizontal=�62   $
��Left=�6L   $��10,0,0,0q�6g   .+�5      �� -   5        $��0q�5   V   
���������6)   Z� ��6?   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ QuestionMark=�6.   5       5"      �� 5$      $	��Top=�6   $ 
Horizontal=�62   $��Right=�6K   .+�5&      �� -   5        $��30��5&      $��0q�6Q   
���������6$   Z� ��6:   Z� .��5'        $ WindowMinimize=�6.   5(      �� 5*      -   5        $��30��5*      $��0q�6Q   
���������6$   Z� ��6:   Z� .��5+        $ WindowMaximize=�6.   5,      �� 5.      -   5        $��30��5.      $��0,0,10,0q�6$   $��0q�6d   
���������67   Z� ��6M   Z� .��5/        $ WindowClose=�6.   50      52      53      � 55   
   $��1��6   .+�58      � .+�59      � $��	250,0,0,0q�6   .+�5:      � -   5         �Name$ GridUserControl��5:      $��Center=�5;      $��Center=�5<      5=      5>      � 5@      $	��250��6   $
��Left=�6#   ��5A      �� 5B      	 �� EndPoint$	 0.5,1&�6.   
 �� 
StartPoint$
 0.5,0&�6?   .��5C      �  � Color$ White��6+    � Offset$ 0Q�69   � 5D      $ #4b798f��6+   $	 0.8Q�6;   � 5E      $ #5e5e5e��6+   $ 1Q�6;   5F      .+�5I      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TransitionEffect��5I   :   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6T   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.3X�.��5J      � -   5        $ 
GridCursor��5J      $��	0,250,0,0q�63   ���#007ac1$��10��6[   $
��Left=�6f   $��60��6�   $	��Top=�6�   5L      �� 5N      -	   5        $	��Top=�5N   -   $��0,50,0,0q�6E   $
��Auto��6W   
������ 
������ .��5O      �� $��/Images/Logo.png��6!   $	��Top=�6;   5Q      �� 5S      -
   5         ��Name$ ListViewMenu��5S      $��	0,250,0,0q�65   
�������$��18(�6[    �� SelectedIndex$ 0��6i   .@�5U      �� $��60��6'   .��5V      �� $ 
Horizontal=�6)   .+�5X   "     $ People=�6:   $��30��6H   $��30��6S   $��Center=�6_   $��5q�6z   �� 5Y   "   $��CHECK-IN��6,   $��17(�6<   $��Center=�6J   $��20,0,0,0q�6e   5[      5\      �� 5_      $��60��6'   .��5`      �� $ 
Horizontal=�6)   .+�5b   "     $ Security=�6:   $��30��6J   $��30��6U   $��Center=�6a   $��5q�6|   �� 5c   "   $��MAINTENENCE��6,   $��17(�6?   $��Center=�6M   $��20,0,0,0q�6h   5e      5f      �� 5h      $��60��6'   .��5i      �� $ 
Horizontal=�6)   .+�5k   "     $ Payment=�6:   $��30��6I   $��30��6T   $��Center=�6`   $��5q�6{   �� 5l   "   $��PAYMENT��6,   $��17(�6;   $��Center=�6I   $��20,0,0,0q�6d   5n      5o      5q      � 5r      $��Bottom=�6   $
��Left=�66   $��15,0,0,0q�6Q   .+�5s      �� -   5        $��30��5s      $��30��6(   $��0q�6a   
�������$��	0,0,50,15q�6�   ��64   Z� ��6J   Z� .��5t        $ Facebook=�62   5u      �� 5v      -   5        $��30��5v   !   $��30��6,   $��0q�6e   
�������$��0,0,0,15q�6�   ��68   Z� ��6N   Z� .��5w        $ Twitter=�62   5x      �� 5y      -   5        $��30��5y   !   $��30��6,   $��0q�6e   
�������$��
0,0,100,15q�6�   ��68   Z� ��6N   Z� .��5z        $	 Web=�66   5{      5|      5}      5~      5      5�      5�      