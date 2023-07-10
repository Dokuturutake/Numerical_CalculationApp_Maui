package crc641ce5bfc0f3dd213c;


public class CircleWidget
	extends android.appwidget.AppWidgetProvider
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAppWidgetOptionsChanged:(Landroid/content/Context;Landroid/appwidget/AppWidgetManager;ILandroid/os/Bundle;)V:GetOnAppWidgetOptionsChanged_Landroid_content_Context_Landroid_appwidget_AppWidgetManager_ILandroid_os_Bundle_Handler\n" +
			"n_onEnabled:(Landroid/content/Context;)V:GetOnEnabled_Landroid_content_Context_Handler\n" +
			"n_onRestored:(Landroid/content/Context;[I[I)V:GetOnRestored_Landroid_content_Context_arrayIarrayIHandler\n" +
			"n_onUpdate:(Landroid/content/Context;Landroid/appwidget/AppWidgetManager;[I)V:GetOnUpdate_Landroid_content_Context_Landroid_appwidget_AppWidgetManager_arrayIHandler\n" +
			"";
		mono.android.Runtime.register ("Numerical_CalculationApp_Maui.CircleWidget, Numerical_CalculationApp_Maui", CircleWidget.class, __md_methods);
	}


	public CircleWidget ()
	{
		super ();
		if (getClass () == CircleWidget.class)
			mono.android.TypeManager.Activate ("Numerical_CalculationApp_Maui.CircleWidget, Numerical_CalculationApp_Maui", "", this, new java.lang.Object[] {  });
	}


	public void onAppWidgetOptionsChanged (android.content.Context p0, android.appwidget.AppWidgetManager p1, int p2, android.os.Bundle p3)
	{
		n_onAppWidgetOptionsChanged (p0, p1, p2, p3);
	}

	private native void n_onAppWidgetOptionsChanged (android.content.Context p0, android.appwidget.AppWidgetManager p1, int p2, android.os.Bundle p3);


	public void onEnabled (android.content.Context p0)
	{
		n_onEnabled (p0);
	}

	private native void n_onEnabled (android.content.Context p0);


	public void onRestored (android.content.Context p0, int[] p1, int[] p2)
	{
		n_onRestored (p0, p1, p2);
	}

	private native void n_onRestored (android.content.Context p0, int[] p1, int[] p2);


	public void onUpdate (android.content.Context p0, android.appwidget.AppWidgetManager p1, int[] p2)
	{
		n_onUpdate (p0, p1, p2);
	}

	private native void n_onUpdate (android.content.Context p0, android.appwidget.AppWidgetManager p1, int[] p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
