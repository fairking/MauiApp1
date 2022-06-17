export function beforeStart(options, extensions) {
    console.log("beforeStart");
}

export function afterStarted(blazor) {
    var jq = document.createElement('script');
    jq.src = "/index.js";
    document.getElementsByTagName('head')[0].appendChild(jq);
}