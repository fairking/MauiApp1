function CallCSharp() {
    try {
        window.DotNet.invokeMethodAsync('MauiApp1', 'CallMeFromJs', "Hello World").then(result => {
            document.getElementById("app").innerHTML = result;
        });
    } catch (error) {
        document.getElementById("app").innerHTML = error;
    }
}

CallCSharp();