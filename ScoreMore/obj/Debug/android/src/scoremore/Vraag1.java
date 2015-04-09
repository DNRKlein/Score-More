package scoremore;


public class Vraag1
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ScoreMore.Vraag1, ScoreMore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Vraag1.class, __md_methods);
	}


	public Vraag1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Vraag1.class)
			mono.android.TypeManager.Activate ("ScoreMore.Vraag1, ScoreMore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
