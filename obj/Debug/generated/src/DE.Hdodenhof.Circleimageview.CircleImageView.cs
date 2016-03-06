using System;
using System.Collections.Generic;
using Android.Runtime;

namespace DE.Hdodenhof.Circleimageview {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']"
	[global::Android.Runtime.Register ("de/hdodenhof/circleimageview/CircleImageView", DoNotGenerateAcw=true)]
	public partial class CircleImageView : global::Android.Widget.ImageView {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("de/hdodenhof/circleimageview/CircleImageView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CircleImageView); }
		}

		protected CircleImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/constructor[@name='CircleImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CircleImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (CircleImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/constructor[@name='CircleImageView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CircleImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (CircleImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/constructor[@name='CircleImageView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CircleImageView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CircleImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getBorderColor;
#pragma warning disable 0169
		static Delegate GetGetBorderColorHandler ()
		{
			if (cb_getBorderColor == null)
				cb_getBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBorderColor);
			return cb_getBorderColor;
		}

		static int n_GetBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::DE.Hdodenhof.Circleimageview.CircleImageView __this = global::Java.Lang.Object.GetObject<global::DE.Hdodenhof.Circleimageview.CircleImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderColor;
		}
#pragma warning restore 0169

		static Delegate cb_setBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetBorderColor_IHandler ()
		{
			if (cb_setBorderColor_I == null)
				cb_setBorderColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBorderColor_I);
			return cb_setBorderColor_I;
		}

		static void n_SetBorderColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::DE.Hdodenhof.Circleimageview.CircleImageView __this = global::Java.Lang.Object.GetObject<global::DE.Hdodenhof.Circleimageview.CircleImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BorderColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBorderColor;
		static IntPtr id_setBorderColor_I;
		public virtual unsafe int BorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/method[@name='getBorderColor' and count(parameter)=0]"
			[Register ("getBorderColor", "()I", "GetGetBorderColorHandler")]
			get {
				if (id_getBorderColor == IntPtr.Zero)
					id_getBorderColor = JNIEnv.GetMethodID (class_ref, "getBorderColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getBorderColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBorderColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/method[@name='setBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBorderColor", "(I)V", "GetSetBorderColor_IHandler")]
			set {
				if (id_setBorderColor_I == IntPtr.Zero)
					id_setBorderColor_I = JNIEnv.GetMethodID (class_ref, "setBorderColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBorderColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBorderColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isBorderOverlay;
#pragma warning disable 0169
		static Delegate GetIsBorderOverlayHandler ()
		{
			if (cb_isBorderOverlay == null)
				cb_isBorderOverlay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBorderOverlay);
			return cb_isBorderOverlay;
		}

		static bool n_IsBorderOverlay (IntPtr jnienv, IntPtr native__this)
		{
			global::DE.Hdodenhof.Circleimageview.CircleImageView __this = global::Java.Lang.Object.GetObject<global::DE.Hdodenhof.Circleimageview.CircleImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderOverlay;
		}
#pragma warning restore 0169

		static Delegate cb_setBorderOverlay_Z;
#pragma warning disable 0169
		static Delegate GetSetBorderOverlay_ZHandler ()
		{
			if (cb_setBorderOverlay_Z == null)
				cb_setBorderOverlay_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBorderOverlay_Z);
			return cb_setBorderOverlay_Z;
		}

		static void n_SetBorderOverlay_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::DE.Hdodenhof.Circleimageview.CircleImageView __this = global::Java.Lang.Object.GetObject<global::DE.Hdodenhof.Circleimageview.CircleImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BorderOverlay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isBorderOverlay;
		static IntPtr id_setBorderOverlay_Z;
		public virtual unsafe bool BorderOverlay {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/method[@name='isBorderOverlay' and count(parameter)=0]"
			[Register ("isBorderOverlay", "()Z", "GetIsBorderOverlayHandler")]
			get {
				if (id_isBorderOverlay == IntPtr.Zero)
					id_isBorderOverlay = JNIEnv.GetMethodID (class_ref, "isBorderOverlay", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isBorderOverlay);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBorderOverlay", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/method[@name='setBorderOverlay' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBorderOverlay", "(Z)V", "GetSetBorderOverlay_ZHandler")]
			set {
				if (id_setBorderOverlay_Z == IntPtr.Zero)
					id_setBorderOverlay_Z = JNIEnv.GetMethodID (class_ref, "setBorderOverlay", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBorderOverlay_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBorderOverlay", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBorderWidth;
#pragma warning disable 0169
		static Delegate GetGetBorderWidthHandler ()
		{
			if (cb_getBorderWidth == null)
				cb_getBorderWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBorderWidth);
			return cb_getBorderWidth;
		}

		static int n_GetBorderWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::DE.Hdodenhof.Circleimageview.CircleImageView __this = global::Java.Lang.Object.GetObject<global::DE.Hdodenhof.Circleimageview.CircleImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setBorderWidth_I;
#pragma warning disable 0169
		static Delegate GetSetBorderWidth_IHandler ()
		{
			if (cb_setBorderWidth_I == null)
				cb_setBorderWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBorderWidth_I);
			return cb_setBorderWidth_I;
		}

		static void n_SetBorderWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::DE.Hdodenhof.Circleimageview.CircleImageView __this = global::Java.Lang.Object.GetObject<global::DE.Hdodenhof.Circleimageview.CircleImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BorderWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBorderWidth;
		static IntPtr id_setBorderWidth_I;
		public virtual unsafe int BorderWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/method[@name='getBorderWidth' and count(parameter)=0]"
			[Register ("getBorderWidth", "()I", "GetGetBorderWidthHandler")]
			get {
				if (id_getBorderWidth == IntPtr.Zero)
					id_getBorderWidth = JNIEnv.GetMethodID (class_ref, "getBorderWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getBorderWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBorderWidth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/method[@name='setBorderWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBorderWidth", "(I)V", "GetSetBorderWidth_IHandler")]
			set {
				if (id_setBorderWidth_I == IntPtr.Zero)
					id_setBorderWidth_I = JNIEnv.GetMethodID (class_ref, "setBorderWidth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBorderWidth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBorderWidth", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFillColor;
#pragma warning disable 0169
		static Delegate GetGetFillColorHandler ()
		{
			if (cb_getFillColor == null)
				cb_getFillColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFillColor);
			return cb_getFillColor;
		}

		static int n_GetFillColor (IntPtr jnienv, IntPtr native__this)
		{
			global::DE.Hdodenhof.Circleimageview.CircleImageView __this = global::Java.Lang.Object.GetObject<global::DE.Hdodenhof.Circleimageview.CircleImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillColor;
		}
#pragma warning restore 0169

		static Delegate cb_setFillColor_I;
#pragma warning disable 0169
		static Delegate GetSetFillColor_IHandler ()
		{
			if (cb_setFillColor_I == null)
				cb_setFillColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFillColor_I);
			return cb_setFillColor_I;
		}

		static void n_SetFillColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::DE.Hdodenhof.Circleimageview.CircleImageView __this = global::Java.Lang.Object.GetObject<global::DE.Hdodenhof.Circleimageview.CircleImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFillColor;
		static IntPtr id_setFillColor_I;
		public virtual unsafe int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getFillColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFillColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/method[@name='setFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFillColor", "(I)V", "GetSetFillColor_IHandler")]
			set {
				if (id_setFillColor_I == IntPtr.Zero)
					id_setFillColor_I = JNIEnv.GetMethodID (class_ref, "setFillColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFillColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_setBorderColorResource_I;
#pragma warning disable 0169
		static Delegate GetSetBorderColorResource_IHandler ()
		{
			if (cb_setBorderColorResource_I == null)
				cb_setBorderColorResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBorderColorResource_I);
			return cb_setBorderColorResource_I;
		}

		static void n_SetBorderColorResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::DE.Hdodenhof.Circleimageview.CircleImageView __this = global::Java.Lang.Object.GetObject<global::DE.Hdodenhof.Circleimageview.CircleImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorderColorResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBorderColorResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/method[@name='setBorderColorResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBorderColorResource", "(I)V", "GetSetBorderColorResource_IHandler")]
		public virtual unsafe void SetBorderColorResource (int p0)
		{
			if (id_setBorderColorResource_I == IntPtr.Zero)
				id_setBorderColorResource_I = JNIEnv.GetMethodID (class_ref, "setBorderColorResource", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBorderColorResource_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBorderColorResource", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFillColorResource_I;
#pragma warning disable 0169
		static Delegate GetSetFillColorResource_IHandler ()
		{
			if (cb_setFillColorResource_I == null)
				cb_setFillColorResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFillColorResource_I);
			return cb_setFillColorResource_I;
		}

		static void n_SetFillColorResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::DE.Hdodenhof.Circleimageview.CircleImageView __this = global::Java.Lang.Object.GetObject<global::DE.Hdodenhof.Circleimageview.CircleImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFillColorResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFillColorResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='CircleImageView']/method[@name='setFillColorResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFillColorResource", "(I)V", "GetSetFillColorResource_IHandler")]
		public virtual unsafe void SetFillColorResource (int p0)
		{
			if (id_setFillColorResource_I == IntPtr.Zero)
				id_setFillColorResource_I = JNIEnv.GetMethodID (class_ref, "setFillColorResource", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFillColorResource_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillColorResource", "(I)V"), __args);
			} finally {
			}
		}

	}
}
