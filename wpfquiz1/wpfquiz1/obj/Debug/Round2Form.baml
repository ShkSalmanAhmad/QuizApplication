   M S B A M L   `   `   `  ����C  ?wpfquiz1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:wpfquiz1wpfquiz1  5   	       wpfquiz1.Round2Form   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:wpfquiz1     5   	   -   5          � WindowState$  	Maximized=�5	   	   
������� � Title$ Quiz Application��5   	   $	��750��6"   $	��650��6/   .��5      ��  �� Padding$ 10q�6   ._�5   
   �� .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   .+�5      �� -   5         ��Name$ TimerTextBlock��5      $
��Wrap=�64   $��0��6I   $��30(�6Z   $�� 10 10 10 10q�6h   �� 5      -   5        $ QuestionTextBlock��5      $
��Wrap=�67   $��0��6L   $��Question��6\   $��50(�6l   $�� 10 30 10 10q�6z   �� 5      -   5         ��Name$ Questionimage��5      $��UniformToFill=�5      $	��450��5      $	��550��5      $��10 10 10 10q�5      $��0��5      5      � 5       5      �� 5      $��* �6'   �� 5       $��* �6'   �� 5!      $��* �6'   .+�5#      �� -   5        $ AnswerTextBlock��5#      $
��Wrap=�65   $��1��6J   $�� ��6Z   $��30(�6c   $�� 60 10 10 10q�6q   5$      � 5%      $��Bottom=�6   $��Stretch=�6.   $��80��6L    5&      �� 5'      $��* �6'   �� 5(      $��* �6'   �� 5)      $��* �6'   �� 5*      $��* �6'   .+�5,      �� -   5         ��Name$ ShowAnswerButton��5,      $��	5 10 5 10q�6S   $��0��6f   $��0��6v   $��Show Answer��6�    ^� ShowDuration$
 2000��6�    ^� BetweenShowDelay$ 10000��5-      	 � ToolTip$	 Show Answer��5.      �� 5/      -   5        $ NextQuestionButton��5/      $��	5 10 5 10q�6V   $��1��6i   $��Pass Question��6y   $
 2000��6�   $ 10000��50      $	 Pass Question��51      �� 52      -   5        $ 
BackButton��52      $��	5 10 5 10q�6G   $��2��6Z   $
��Back��6j   $
 2000��6y   $ 10000��53      $
	 Back��54      �� 55      -	   5        $ 
ExitButton��55      $��	5 10 5 10q�6F   $��3��6Y   $��0��6i   $
��Exit��6v   $
 2000��6�   $ 10000��56      $
	 Exit��57      58      59      5:      5;      