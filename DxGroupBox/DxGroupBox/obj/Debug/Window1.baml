   M S B A M L   `   `   `  ����E  ADxGroupBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DxGroupBox.DataDxGroupBox.Data  5   P       DxGroupBox.Window1   5      d `DevExpress.Xpf.Docking.v17.1, Version=17.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxdo5http://schemas.devexpress.com/winfx/2008/xaml/docking  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.1, Version=17.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5      j fDevExpress.Xpf.LayoutControl.v17.1, Version=17.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aFdxlc;http://schemas.devexpress.com/winfx/2008/xaml/layoutcontrol  5      ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5      (Dataclr-namespace:DxGroupBox.Data  6P     � Title$  
MainWindow��5      $	��350��6!   $	��525��6.    � DataContext 5	          DxGroupBox.Data.Repository  5
   
   .��5      � .+�5   
   4  .DevExpress.Xpf.LayoutControl.FlowLayoutControl     ItemsSource 6!   �� *
Contacts+   ItemTemplate 5      �� 5      .R�5      +  %DevExpress.Xpf.LayoutControl.GroupBox      MaximizeElementVisibility$ Visible=�5   $   $	��100��5   $   ,  &DevExpress.Xpf.Core.ContentControlBase   Content 5   $   �� 4  .DevExpress.Xpf.Core.HeaderedContentControlBase   Header 5   $   �� *Name+   IsFlowBreak 5   $   �� *
IsNewGroup+   ContentTemplate 5      �� 5      .R�5   "   �� .+�5   &   �� $��UniformToFill=�6E   $��50��6]   $��50��6h   ��6,   �� *Photo+6h   5   #   5      H  BDevExpress.Xpf.LayoutControl.MaximizableHeaderedContentControlBase	   MaximizedContentTemplate	 5      �� 5      .R�5   "   0  *DevExpress.Xpf.LayoutControl.LayoutControl  .  (DevExpress.Xpf.LayoutControl.LayoutGroup
   Orientation$
 Vertical=�65   .+�5   &     $
 
Horizontal=�67   .+�5    *   �� $��UniformToFill=�6I   $	��150��6a   $	��150��6m   ��60   �� *Photo+6m     5!   *   $
 Vertical=�6;   .+�5"   .   -	  'DevExpress.Xpf.LayoutControl.LayoutItem	   	  Label$ 
First Name��6>    	  Content. 5#   2   %
  DevExpress.Xpf.Editors.TextEdit
  %  DevExpress.Xpf.Editors.BaseEdit   	EditValue 6?   �� *	FirstName+5$   /   	  5%   .   $ 	Last Name��6>   . 5&   2   
   6?   �� *
LastName+5'   /   5(   +   5)   '     5*   &   $
 Vertical=�67   .+�5+   *   	  $ Email��6:   . 5,   .   
   6;   �� *Email+5-   +   	  5.   *   $ Phone��6:   . 5/   .   
   6;   �� *Phone+50   +   	  51   *   $ Address��6:   . 52   .   
   6;   �� *	Address+53   +   	  54   *   $
 City��6:   . 55   .   
   6;   �� *City+56   +   	  57   *   $ State��6:   . 58   .   
   6;   �� *State+59   +   	  5:   *   $	 Zip��6:   . 5;   .   
   6;   �� *Zip+5<   +   5=   '   5>   #   5?      5A      5B      5D      5E      5F      