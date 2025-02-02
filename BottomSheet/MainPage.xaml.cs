﻿namespace BottomSheet;

public partial class MainPage : ContentPage
{
	public int Count { get; set; }
	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Count++;
		OnPropertyChanged(nameof(Count));
	}

	private void ShowBottomSheet(object sender, EventArgs e)
	{
		this.ShowBottomSheet(GetBottomSheetView(), true);
	}


	private View GetBottomSheetView()
	{
		var view = (View)BottomSheetTemplate.CreateContent();
		view.BindingContext = BindingContext;
		return view;
	}

	private void ShowBottomSheetWithLongContent(object sender, EventArgs e)
	{
		this.ShowBottomSheet(GetBottomSheetViewWithLongContent(), false);
	}

	private View GetBottomSheetViewWithLongContent()
	{
		var view = (View)BottomSheetTemplateWithLongContent.CreateContent();
		view.BindingContext = BindingContext;
		return view;
	}
}