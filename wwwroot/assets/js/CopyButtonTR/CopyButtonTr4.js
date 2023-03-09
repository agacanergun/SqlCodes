//4
var CopyButton4 = document.getElementById("CopyButton4");

CopyButton4.addEventListener("mouseover", function () {
    CopyButton4.style.color = "#00b4d8";
    CopyButton4.style.backgroundColor = "#2b3034";
});

CopyButton4.addEventListener("mouseout", function () {
    CopyButton4.style.color = "#F0FFFF";
    CopyButton4.style.backgroundColor = "#2b3034";
});

//4
const copyButton4 = document.querySelector('#CopyButton4');
const codeBlock4 = document.querySelector('#test4 code');


copyButton4.addEventListener('click', () => {
    const code4 = codeBlock4.innerText;
    navigator.clipboard.writeText(code4)
        .then(() => {
            copyButton4.innerHTML = '<svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-check" viewBox="0 0 16 16"><path d="M5.97 10.56 3.25 7.84a.5.5 0 0 1 .7-.7l2.96 2.97 6.3-6.3a.5.5 0 0 1 .7.7l-6.75 6.75a.5.5 0 0 1-.7 0z"/></svg> Kopyalandı!';
            setTimeout(() => {
                copyButton4.innerHTML = '<svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-clipboard" viewBox="0 0 16 16"><path d="M4 1.5H3a2 2 0 0 0-2 2V14a2 2 0 0 0 2 2h10a2 2 0 0 0 2-2V3.5a2 2 0 0 0-2-2h-1v1h1a1 1 0 0 1 1 1V14a1 1 0 0 1-1 1H3a1 1 0 0 1-1-1V3.5a1 1 0 0 1 1-1h1v-1z"/><path d="M9.5 1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-3a.5.5 0 0 1-.5-.5v-1a.5.5 0 0 1 .5-.5h3zm-3-1A1.5 1.5 0 0 0 5 1.5v1A1.5 1.5 0 0 0 6.5 4h3A1.5 1.5 0 0 0 11 2.5v-1A1.5 1.5 0 0 0 9.5 0h-3z"/></svg>';
            }, 2000);
        })
        .catch(err => {
            console.error('Kopyalama hatası:', err);
        });
});