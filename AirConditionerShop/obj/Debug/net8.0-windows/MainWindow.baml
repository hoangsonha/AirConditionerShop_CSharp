   M S B A M L   `   `   `  ����M  IAirConditionerShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AirConditionerShopAirConditionerShop  5   	   #    AirConditionerShop.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AirConditionerShop     5   	   -   5          � Title$"  AirConditionerShopManagement��5   	   $	��600��6.   $
��1000��6;   ���#7bed9f � WindowStartupLocation$ CenterScreen=�6]    � 
ResizeMode$ NoResize=�6�   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AirConDataGrid��5
      $��Center=�6+   $	��332��6H   $��	0,223,0,0q�6U   $	��Top=�6h   $	��980��6�      AutoGenerateColumns$ False��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *AirConditionerId+  5      $ Air Name��6%   $	 200 67    6C   �� *AirConditionerName+  5      $ Warranty��6%   $ 70 67    6B   �� *AirConditionerId+  5      $ SoundPressureLevel��6%   $	 100 6A    6M   �� *SoundPressureLevel+  5      $ FeatureFunction��6%   $	 200 6>    6J   �� *FeatureFunction+  5      $ Quantity��6%   $ 70 67    6B   �� *
Quantity+  5      $ 	Price ($)��6%   $	 100 68    6D   �� *DollarPrice+  5      $ SupplierId ��6%   $ 70 6:    6E   �� *
SupplierId+  5      $ SupplierName ��6%   $	 120 6<    6H   �� *Supplier.SupplierName+5      �� 5   
   ���#ffcba4$��Center=�6#   $	��120��6@   
���   �$	��Top=�6\   $
��1000��6t   �� 5   
   -   5        	 ��Name$	 
SearchText��5      $
��Left=�6&   $��
10,149,0,0q�6A   
 �� TextWrapping$

 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��263��6�   $��43��6�   �� 5   
   -   5        $��Search��5      ���#7cfc00$
��Left=�67   $��278,144,0,0q�6R   $	��Top=�6g   $��51��6   $	��130��6�   6�   �� 5   
   -   5         ��Name$ CreateButton��5      $��
Create Air��6'   ���#7cfc00$
��Left=�6Q   $��444,145,0,0q�6l   $	��Top=�6�   $	��164��6�   $��51��6�   6�   �� 5   
   -   5        $ UpdateButton��5      $��
Update Air��6'   ���#7cfc00$
��Left=�6Q   $��629,144,0,0q�6l   $	��Top=�6�   $��51��6�   $	��164��6�   6�   �� 5   
   -   5        $ DeleteButton��5      $��
Delete Air��6'   ���#7cfc00$
��Left=�6Q   $��811,145,0,0q�6l   $	��Top=�6�   $	��164��6�   $��51��6�   6�   �� 5    
   $��AirConditioner Management��6   $��30(�64   $��	ExtraBold"�6B   $
��Left=�6Y   $��
-21,35,0,0q�6t   $	��Top=�6�   $	��490��6�   �� 5!   
   -   5         ��Name$ Wellcome��5!      $��20(�6"   $
��Left=�60   $��
784,33,0,0q�6K   $	��Top=�6_   5"      5#      