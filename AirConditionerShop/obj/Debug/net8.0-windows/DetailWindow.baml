   M S B A M L   `   `   `  ����M  IAirConditionerShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AirConditionerShopAirConditionerShop  5   	   %    AirConditionerShop.DetailWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AirConditionerShop     5   	   -   5          � Title$"  AirConditionerShopManagement��5   
   $	��600��6/   $
��1000��6<   ���#7bed9f � WindowStartupLocation$ CenterScreen=�6^    � 
ResizeMode$ NoResize=�6�   .��5	      � .+�5
   
   �� ���#ffcba4$��Center=�6#   $	��131��6@   
���   �$	��Top=�6\   $
��1000��6t   �� 5   
   ���#ffcba4$��Center=�6#   $	��373��6@   $��	0,186,0,0q�6M   
���   �$	��Top=�6o   $	��940��6�   �� 5   
   $��Air Conditioner ID��6   $
��Left=�6-   $��
87,225,0,0q�6H   $	��Top=�6\   $��30��6t   �� 5   
   $��Air Conditioner Name��6   $
��Left=�6/   $��511,225,0,0q�6J   $	��Top=�6_   �� 5   
   $��SupplierName��6   $
��Left=�6'   $��511,421,0,0q�6B   $	��Top=�6W   �� 5   
   $��Sound Level��6   $
��Left=�6&   $��511,290,0,0q�6A   $	��Top=�6V   �� 5   
   $��Quantity��6   $
��Left=�6#   $��511,360,0,0q�6>   $	��Top=�6S   �� 5   
   $��DollarPrice��6   $
��Left=�6&   $��
87,420,0,0q�6A   $	��Top=�6U   �� 5   
   $��FeatureFunction��6   $
��Left=�6*   $��
87,359,0,0q�6E   $	��Top=�6Y   �� 5   
   $��Warranly��6   $
��Left=�6#   $��
87,290,0,0q�6>   $	��Top=�6R   $��80��6j   �� 5   
   -   5         ��Name$ AirConditionerIdTextBox��5      $��1��6   $
��Left=�6@   $��242,221,0,0q�6[    �� TextWrapping$
 Wrap=�6p   $�� ��6�   $	��Top=�6�   $	��221��6�   $��34��6�   �� 5   
   -   5         ��Name$ SupplierIdComboBox��5       $��8��6   $
��Left=�6<   $��690,420,0,0q�6W   $	��Top=�6l   $	��229��6�   $��32��6�   �� 5   
   -   5        $ DollarPriceTextBox��5      $��7��6   $
��Left=�6;   $��242,420,0,0q�6V   $
 Wrap=�6k   $�� ��6   $	��Top=�6�   $	��221��6�   $��32��6�   �� 5   
   -   5        $ QuantityTextBox��5      $��6��6   $
��Left=�68   $��690,358,0,0q�6S   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��229��6�   $��31��6�   �� 5   
   -   5        $ FeatureFunctionTextBox��5      $��5��6   $
��Left=�6?   $��242,357,0,0q�6Z   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��221��6�   $��33��6�   �� 5   
   -   5        $ SoundPressureLevelTextBox��5      $��4��6   $
��Left=�6B   $��690,288,0,0q�6]   $
 Wrap=�6r   $�� ��6�   $	��Top=�6�   $	��229��6�   $��34��6�   �� 5   
   -   5        $ WarrantyTextBox��5      $��3��6   $
��Left=�68   $��242,288,0,0q�6S   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��221��6�   $��34��6�   �� 5   
   -	   5        $ AirConditionerNameTextBox��5      $��2��6   $
��Left=�6B   $��691,222,0,0q�6]   $
 Wrap=�6r   $�� ��6�   $	��Top=�6�   $	��227��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��37��6�   .��6�   z�5      V� 5      .~�5      �� �� 5      �� 5        �� Angle$ 0.094Q�6&   T� 5!      5"      .��5#   '   5$      �� 5%   
   -
   5         ��Name$ 
SaveButton��5%   8   $��9��6   
���/���$��Save Air��6L   $
��Left=�6_   $��242,486,0,0q�6z   $	��Top=�6�   $	��155��6�   $��44��6�   ���	#FF08BEF16�   �� 5&   
   -   5        $ CloseButton��5&      $��10��6   $��Close��65   $
��Left=�6E   $��501,486,0,0q�6`   $	��Top=�6u   $	��150��6�   $��44��6�   ���	#FF549AAE6�   �� 5'   
   -   5        	 ��Name$	 DetailWindowMode��5'      $��30(�6*   $%��Create | Update Air Conditioner��68   $
��Left=�6b   $��	30,38,0,0q�6}   $	��Top=�6�   5)      5*      