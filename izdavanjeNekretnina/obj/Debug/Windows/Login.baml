   M S B A M L   `   `   `  ����N  JizdavanjeNekretnina, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:izdavanjeNekretnina.WindowsizdavanjeNekretnina.Windows  5   	   '    !izdavanjeNekretnina.Windows.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:izdavanjeNekretnina.Windows     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $	��550��5   	   $	��400��6   .��5      � $	��550��6   $��Bottom=�6   
�������.+�5   
   �� $	��400��6   $	��550��6    � 5   
   -   5        $��	0,0,0,510q�5      ���#575759.+�5      �� $	��Top=�6    �� Orientation$ 
Horizontal=�62   $��Right=�6L   .+�5      �� -   5        $��0q�5   V   
���������6)   Z� ��6?   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ QuestionMark=�6.   5      �� 5       -   5        $��30��5       $��0,0,10,0q�6$   $��0q�6d   
���������67   Z� ��6M   Z� .��5!        $ WindowClose=�6   5"      5$      5%      � 5&      $	��Top=�6	   .+�5'      �� $��/Images/Logo.png��6   $��
40,70,40,0q�6%   5(      �� 5*      $ Vertical=�6   $��Bottom=�6&   $��40q�6A   .+�5,      �� -   5         ��Name$ TextBox��5,      
�������$	��Top=�51       % !MaterialDesignFloatingHintTextBox#��[ 52      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��53      $��48��54   �   {�6   �� 	 �� Path$	 	IsChecked�
 �� ElementName$9
 3MaterialDesignFilledTextFieldTextBoxEnabledComboBox��6�   G� 57      -   5         G�Name$ PasswordBox��57      
�������$	��Top=�5;       ) %MaterialDesignFloatingHintPasswordBox#��[ 5<      $ Password��5=      $��47��6E   �� 5?      $ 
Horizontal=�6   $
��0,30q�6)   5A      �� 5E      -   5        $	��200��5E       " MaterialDesignRaisedDarkButton#��[ 5F      $��40��5G      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��5H       � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners��5I      $��0,40,0,0q�6I   .��5K      �� $ 
Horizontal=�6   .+�5L      �� $��LOGIN��6     5M      $ Login=�6   $��20,0,0,0q�6,   5N      5O      5R      5T      5U      