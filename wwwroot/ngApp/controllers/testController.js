class TestController {
    constructor() {
        this.message = "this is the test view";
        // var gameInstance = UnityLoader.instantiate("gameContainer", "Build/Builds.json", {onProgress: UnityProgress});
        var gameInstance = UnityLoader.instantiate("gameContainer", "Build/game.json", {onProgress: UnityProgress});

        // https://codetolight.wordpress.com/2017/01/18/unity-rest-api-interaction-with-unitywebrequest-and-besthttp/
        // https://docs.unity3d.com/ScriptReference/Networking.UnityWebRequest.Post.html
        // https://docs.unity3d.com/Manual/UnityWebRequest-RetrievingTextBinaryData.html
    }
}