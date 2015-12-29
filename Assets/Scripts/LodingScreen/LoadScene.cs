using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

    private AsyncOperation async = null;
    private bool isLoading = false;
    public Texture backgroundBar;
    public Texture lineBar;
    public Texture GUITextureBackground;
    private static bool _currentLoadScenes = true;

        private IEnumerator _Start(){
        if (_currentLoadScenes)
        {
            Singleton.Instance._chooseMap = "TestForWindows";
            _currentLoadScenes = false;
        }
        async = Application.LoadLevelAsync( Singleton.Instance._chooseMap );
        while( !async.isDone ){
                        Debug.Log( string.Format( "Loading {0}%", async.progress*100 ) );
                        yield return null;
                }
                isLoading = false;
                yield return async;
        }

        private void OnGUI(){
      if(GUITextureBackground != null)
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), GUITextureBackground);
                if( !isLoading ){
                        {
                                isLoading = true;
                                StartCoroutine("_Start"); 
                        }
                } else{
         GUI.Label(new Rect( (Screen.width / 2)-70, (Screen.height / 2) + (Screen.height / 3)-20, 512, 30),"Loading...");
                        GUI.DrawTexture( new Rect( (Screen.width / 2) -300, (Screen.height / 2) + (Screen.height / 3), 512, 10 ), backgroundBar, ScaleMode.StretchToFill, true, 1F);
         GUI.DrawTexture( new Rect( (Screen.width / 2) -300, (Screen.height / 2) + (Screen.height / 3), async.progress*512, 10 ), lineBar, ScaleMode.StretchToFill, true, 1F);
                }
        }
}