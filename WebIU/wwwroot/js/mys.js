var canvas, ctx, painting = false, previousMousePosition;

function getMousePosition(event) {
    var rect = canvas.getBoundingClientRect();
    

    return {
        x: event.clientX – rect.left,
        y: event.clientY – rect.top
    };
}

function drawLine(x1, y1, x2, y2) {
    ctx.beginPath();
    ctx.moveTo(x1, y1);
    ctx.lineTo(x2, y2);
    ctx.stroke();
}

function handleMouseMove(e) {
    var mousePos = getMousePosition(e);

    if (painting) {
        drawLine(previousMousePosition.x, previousMousePosition.y, mousePos.x, mousePos.y);
        previousMousePosition = mousePos;
    }
}

window.onload = function () {
    canvas = document.getElementById('cizimAlani');
    ctx = canvas.getContext('2d');
    canvas.addEventListener('mousemove', handleMouseMove, false);
    canvas.addEventListener('mousedown', function (e) {
        previousMousePosition = getMousePosition(e);
        painting = true;
    });
    canvas.addEventListener('mouseup', function () {
        painting = false;
    });
};