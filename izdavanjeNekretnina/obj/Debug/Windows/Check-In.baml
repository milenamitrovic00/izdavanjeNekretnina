   M S B A M L   `   `   `  ����N  JizdavanjeNekretnina, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:izdavanjeNekretnina.WindowsizdavanjeNekretnina.Windows  5      *    $izdavanjeNekretnina.Windows.Check_In   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:izdavanjeNekretnina.Windows     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   $
��auto��5   	   $
��auto��6   .��5      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ Effect��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6>   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      � $	��Top=�6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      � $��0��6   .+�5      �� $��Center=�6!   $��Bottom=�6>   .+�5       �� 5"      �� 5#       �� Orientation$ 
Horizontal=�6%   $	��310��6>   $��10q�6J   .+�5$      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�66   $��Center=�6E   �� 5%      -   5         ��Name$
 Name��5%   &   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$
	 Name��64   $	��300��6Z   
�������$��Rubik)�6x   $��5q�6�   5&      �� 5(      $ 
Horizontal=�6%   $	��310��6>   $��10q�6J   .+�5)        $ 
AccountAdd=�66   $��Center=�6H   �� 5*      -   5        $ Surname��5*   &   $	 Surname��67   $	��300��6`   
�������$��Rubik)�6~   $��5q�6�   6�   5+      �� 5-      $ 
Horizontal=�6%   $	��310��6>   $��10q�6J   .+�5.        $ IdCard=�66   $��Center=�6D   �� 5/      -   5        $ ID��5/   &   $	 ID��62   $	��300��6V   
�������$��Rubik)�6t   $��5q�6�   6�   50      �� 52      $ 
Horizontal=�6%   $	��310��6>   $��10q�6J   .+�53        $ Phone=�66   $��Center=�6C   �� 54      -   5        $ PhoneNumber��54   &   $	 Phone Number��6;   $	��300��6i   
�������$��Rubik)�6�   $��5q�6�   6�   55      �� 57      $ 
Horizontal=�6%   $	��310��6>   $��10q�6J   .+�58      (  "System.Windows.Controls.DatePicker  -   5        
  Name$
 CheckIn��58   *   $	 Reservation Check-in Date��6;   $	��300��6v   
�������$��Rubik)�6�   $��5q�6�      DisplayDateStart$ 
2022-05-01X�6�      DisplayDateEnd$ 
2023-05-31X�6�   6�   59      �� 5;      $ 
Horizontal=�6%   $	��310��6>   $��10q�6J   .+�5<        -   5        $
 CheckOut��5<   )   $ 	 Reservation Check-out Date��6;   $	��300��6w   
�������$��Rubik)�6�   $��5q�6�   $ 
2022-05-01X�6�   $ 
2023-05-31X�6�   6�   5=      �� 5@      -   5        $	��150��5@   !    " MaterialDesignRaisedDarkButton#��[ 5B      $��30��5C      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��5D       � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners��5E      $��20q�6I   .��5H      �� $ 
Horizontal=�6)   .+�5I   "   �� $
��Rent��6,   5K      5L      5N      5O      5U      5V      5W      5X      