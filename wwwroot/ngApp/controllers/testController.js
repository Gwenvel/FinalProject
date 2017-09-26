class TestController {
    constructor() {
        this.message = "this is the test view";
        var gameInstance = UnityLoader.instantiate("gameContainer", "Build/Builds.json", {onProgress: UnityProgress});
    }
}