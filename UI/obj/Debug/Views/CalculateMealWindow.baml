   M S B A M L   `   `   `  ����  HostelManagementSystem.UI9    3HostelManagementSystem.UI.Views.CalculateMealWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  CalculateMealWindow��5      $	��600��5   	   $	��600��6      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5
   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�6;   .��5      � .+�5   
   �� $��Choose User��6   $
��Left=�6&   $��	37,33,0,0q�6A   $	��Top=�6T   $��80��6l   $��27��6w   �� 5   
   -   5         ��Name$ 
ChooseUser��5   %    �� SelectedIndex$ 0��6   $
��Left=�69   $��
163,35,0,0q�6U   $	��Top=�6i   $	��125��6�   $��27��6�   �� 5   
   $��Month��6   $
��Left=�6    $��
349,35,0,0q�6;   $	��Top=�6O   $��27��6g   $��50��6s    J� RenderTransformOrigin$ 0.346,-1.48&�6~   �� 5   
   -   5        $ 
ChooseYear��5   %   $ 0��6   $
��Left=�69   $��
163,87,0,0q�6T   $	��Top=�6j   $	��125��6�   $��24��6�   �� 5   
   $
��Date��6   $
��Left=�6   $��	75,87,0,0q�6:   $	��Top=�6M   $��29��6e   $��42��6q   $ 
0.729,-1.4&�6|   �� 5   
   -   5        $ ChooseMonth��5      $
��Left=�6)   $��
432,35,0,0q�6D   $	��Top=�6X   $	��125��6p   $ 1.278,1.005&�6|   $��25��6�   �� 5   
   $��Bazar Amount��6   $
��Left=�6'   $��
332,87,0,0q�6B   $	��Top=�6V   $ 0.549,0.923&�6n   $��24��6�   $��95��6�   �� 5   
   -   5         ��Name$ BazarAmount��5      $
��Left=�6(   $��24��6C   $��
432,87,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��125��6�   $ 0.627,2.219&�6�   �� 5   
   $��
Meal Count��6   $
��Left=�6%   $��
49,141,0,0q�6@   $	��Top=�6T   $��27��6l   $��80��6x   �� 5   
   -   5        $ 	MealCount��5      $
��Left=�6%   $��27��6@   $��163,141,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��125��6�   �� 5    
   -   5        	 ��Name$		 Add��5       $	��Add��6   $
��Left=�6,   $��392,177,0,0q�6G   $	��Top=�6\   $��93��6t   $��33��6   $ 0.467,-0.532&�6�   6�   �� 5!   
   -   5        $	 _Refresh��5!      $��Reset��6#   $
��Left=�63   $��490,177,0,0q�6N   $	��Top=�6c   $��84��6{   $��33��6�   $ 0.145,0.517&�6�   &   System.Windows.Controls.DataGrid  5"   
   -   5        
  Name$

 Cart��5"         SelectionUnit$ FullRow=�6!   -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 20q�69   
�������$
��Left=�6�   $	��252��6�   $��
10,236,0,0q�6�   $	��Top=�6�   $	��580��6�      CanUserAddRows .  6�   �� 5#   
   -	   5        $	 ManageUsers��5#      $��Manage Users��6&   $
��Left=�6=   $��134,515,0,0q�6X   $	��Top=�6m   $	��126��6�   $��44��6�   6�   �� 5$   
   -
   5        $	 	Dashboard��5$      $��	Dashboard��6$   $
��Left=�68   $��
10,515,0,0q�6S   $	��Top=�6g   $	��119��6   $��44��6�   6�   �� 5%   
   -   5        $	 	Calculate��5%      $��	Calculate��6$   $
��Left=�68   $��442,515,0,0q�6S   $	��Top=�6h   $	��115��6�   $��44��6�   6�   5&      5'      