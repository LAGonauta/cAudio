/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace cAudio {

using System;
using System.Runtime.InteropServices;

public class IAudioPlugin : IRefCounted {
  private HandleRef swigCPtr;

  internal IAudioPlugin(IntPtr cPtr, bool cMemoryOwn) : base(cAudioCSharpWrapperPINVOKE.IAudioPlugin_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IAudioPlugin obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IAudioPlugin() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          cAudioCSharpWrapperPINVOKE.delete_IAudioPlugin(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual bool installPlugin(ILogger logger) {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioPlugin_installPlugin(swigCPtr, ILogger.getCPtr(logger));
    return ret;
  }

  public virtual string getPluginName() {
    string ret = cAudioCSharpWrapperPINVOKE.IAudioPlugin_getPluginName(swigCPtr);
    return ret;
  }

  public virtual void uninstallPlugin() {
    cAudioCSharpWrapperPINVOKE.IAudioPlugin_uninstallPlugin(swigCPtr);
  }

  public virtual void onCreateAudioManager(IAudioManager manager) {
    cAudioCSharpWrapperPINVOKE.IAudioPlugin_onCreateAudioManager(swigCPtr, IAudioManager.getCPtr(manager));
  }

  public virtual void onCreateAudioCapture(IAudioCapture capture) {
    cAudioCSharpWrapperPINVOKE.IAudioPlugin_onCreateAudioCapture(swigCPtr, IAudioCapture.getCPtr(capture));
  }

  public virtual void onDestroyAudioManager(IAudioManager manager) {
    cAudioCSharpWrapperPINVOKE.IAudioPlugin_onDestroyAudioManager(swigCPtr, IAudioManager.getCPtr(manager));
  }

  public virtual void onDestoryAudioCapture(IAudioCapture capture) {
    cAudioCSharpWrapperPINVOKE.IAudioPlugin_onDestoryAudioCapture(swigCPtr, IAudioCapture.getCPtr(capture));
  }

}

}
