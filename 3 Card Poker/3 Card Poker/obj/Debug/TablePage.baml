   M S B A M L   `   `   `  ����G  C3 Card Poker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:_3_Card_Poker_3_Card_Poker  5          _3_Card_Poker.TablePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:_3_Card_Poker     5        N� 
Background
  ����� N� Title$ 	TablePage��5
      .��5      � .+�5   
   � $��Center=�6   $	��400��6,   $��Center=�69   $	��400��6T   .+�5      � $	��175��6   $��Bottom=�6    $	��400��6;   .+�5      �� -   5         ��Name$ p1_rectangle1��5      
�������$
��Left=�6C   $	��Top=�6^   $	��140��6v   
���   �$	��100��6�   $��2��6�    �� RadiusX$ 5��6�    �� RadiusY$ 5��6�   �� 5      -   5        $ p1_rectangle2��5      
�������$��Center=�6C   $	��Top=�6`   $	��140��6x   
���   �$	��100��6�   $��2��6�   $ 5��6�   $ 5��6�   �� 5      -   5        $ p1_rectangle3��5      
�������$��Right=�6C   $	��Top=�6_   $	��140��6w   
���   �$	��100��6�   $��2��6�   $ 5��6�   $ 5��6�   �� 5      -   5         ��Name$ p1_card1��5      $
��Left=�6*   $��Center=�6E   $��79��6`   $	��100��6l   $��36(�6x   $��Center=�6�   $��0,0,0,20q�6�   $
��Bold"�6�   �� 5      -   5        $ p1_card2��5      $��Center=�6*   $��Center=�6G   $��79��6b   $	��100��6n   $��36(�6z   $��Center=�6�   $��0,0,0,20q�6�   $
��Bold"�6�   �� 5      -   5        $ p1_card3��5      $��Right=�6*   $��Center=�6F   $��79��6a   $	��100��6m   $��36(�6y   $��Center=�6�   $��0,0,0,20q�6�   $
��Bold"�6�   �� 5      -   5         ��Name$ 	handrank1��5      $��Bottom=�6/   $��30��6J   $��30(�6V   $��Olivia Brush)�6d   $
��Bold"�6~    �� TextAlignment$ Center=�6�   5      � 5      $	��175��6   $	��Top=�6    $	��400��68   .+�5      �� -   5        $ p2_rectangle1��5      
�������$
��Left=�6C   $��Bottom=�6^   $	��140��6y   
���   �$	��100��6�   $��2��6�   $ 5��6�   $ 5��6�   �� 5      -	   5        $ p2_rectangle2��5      
�������$��Center=�6C   $��Bottom=�6`   $	��140��6{   
���   �$	��100��6�   $��2��6�   $ 5��6�   $ 5��6�   �� 5      -
   5        $ p2_rectangle3��5      
�������$��Right=�6C   $��Bottom=�6_   $	��140��6z   
���   �$	��100��6�   $��2��6�   $ 5��6�   $ 5��6�   �� 5      -   5        $ p2_card1��5      $
��Left=�6*   $��Center=�6E   $��79��6`   $	��100��6l   $��36(�6x   $��Center=�6�   $��0,50,0,0q�6�   $
��Bold"�6�   �� 5      -   5        $ p2_card2��5      $��Center=�6*   $��Center=�6G   $��79��6b   $	��100��6n   $��36(�6z   $��Center=�6�   $��0,50,0,0q�6�   $
��Bold"�6�   �� 5      -   5        $ p2_card3��5      $��Right=�6*   $��Center=�6F   $��79��6a   $	��100��6m   $��36(�6y   $��Center=�6�   $��0,50,0,0q�6�   $
��Bold"�6�   �� 5      -   5        $ 	handrank2��5      $	��Top=�6/   $��30��6G   $��30(�6S   $��Olivia Brush)�6a   $
��Bold"�6{   $ Center=�6�   5      5       �� 5!   
   -   5        $ 
tb_player1��5!      $��Bottom=�6(   $
��Left=�6C   $��30(�6^   $
��Bold"�6l   $��Edo SZ)�6~   $ Center=�6�   $��50��6�   $	��200��6�   $��	10,0,0,10q�6�   �� 5"   
   -   5        $ 
tb_player2��5"      $��	PC: Robot��6(   $��Right=�69   $	��Top=�6U   $��50��6m   $��30(�6y   $
��Bold"�6�   $��Edo SZ)�6�   $
 Left=�6�   $	��200��6�   $��	0,10,10,0q�6�   �� 5#   
    �� Orientation$ Vertical=�6   $��Right=�6,   $	��300��6H   $��Bottom=�6U   $	��200��6p   .+�5$      �� -   5        	 ��Name$
	 hide��5$      $
��HIDE��6#   $	��100��62   $��50��6>   $��18(�6J   $
��Bold"�6X   ���	#FFFFF9BE$��3q�6�   $��0,0,0,10q�6�   $��Edo SZ)�6�   6�   �� 5%      -   5        $	 expose��5%      $��EXPOSE��6%   $	��100��66   $��50��6B   $��18(�6N   $
��Bold"�6\   ���	#FFFFF9BE$��3q�6�   $��0,0,0,10q�6�   $��Edo SZ)�6�   �� 5&      -   5        $
	 fold��5&      $
��FOLD��6#   $	��100��62   $��50��6>   $��18(�6J   $
��Bold"�6X   ���	#FFFFF9BE$��3q�6�   {�.  $��0,0,0,10q�6�   $��Edo SZ)�6�   6�   �� 5'      -   5        $	 showdown��5'      $��SHOWDOWN��6'   $	��100��6:   $��50��6F   $��18(�6R   $
��Bold"�6`   ���	#FFFFF9BE$��3q�6�   {�.  $��0,0,0,10q�6�   $��Edo SZ)�6�   6�   �� 5(      -   5        $	 newgame��5(      $��NEW GAME��6&   $	��100��69   $��50��6E   $��18(�6Q   $
��Bold"�6_   ���	#FFFFF9BE$��3q�6�   {�.  $��Edo SZ)�6�   6�   
 � Triggers
 5)      :� 5*       :� 
SourceName$
 fold��6    :� RoutedEvent$ Button.Click��61   .[�5+      �� .��5,      �� .��5-      W�  �� 
TargetName$ 	winorlose��5.   !    �� TargetProperty$ (TextBlock.Opacity)�6C    W� From$	 0.0X�6s   	 W� To$	 1.0X�6~    g� Duration$ 0:0:1D�6�    g� RepeatBehavior$ 1x��6�   5/      50      51      :� 52      $ showdown��6   $ Button.Click��65   .[�53      �� .��54      �� .��55      W� $ 	winorlose��56   !   $ (TextBlock.Opacity)�6C   $	 0.0X�6s   $	 1.0X�6~   $ 0:0:1D�6�   $ 1x��6�   57      58      59      5;      �� 5<   
   -   5        $ 	winorlose��5<      $��Center=�6'   $��Center=�6D   $	��500��6_   $	��100��6k   $	��100(�6x   $��Olivia Brush)�6�   $
��Bold"�6�   $ Center=�6�    J� Effect 5=      3  -System.Windows.Media.Effects.DropShadowEffect  5>         ShadowDepth$ 10Q�6#      	Direction$	 315Q�64      Opacity$	 0.4Q�6D      
BlurRadius$ 10Q�6R   5@      5A      5B      