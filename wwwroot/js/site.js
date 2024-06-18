// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Adding chart.js to the document Javascript:
<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>;

document.addEventListener("DOMContentLoaded", function () {
  var calendarEl = document.getElementById("calendar");

  var calendar = new FullCalendar.Calendar(calendarEl, {
    timeZone: "UTC",
    initialView: "dayGridWeek",
    headerToolbar: {
      left: "prev,next",
      center: "title",
      right: "dayGridWeek,dayGridDay",
    },
    editable: true,
    events: "https://fullcalendar.io/api/demo-feeds/events.json",
  });

  calendar.render();
});

// Clock
function startTime() {
  const today = new Date();
  let h = today.getHours();
  let m = today.getMinutes();
  let s = today.getSeconds();
  m = checkTime(m);
  s = checkTime(s);
  document.getElementById("clock").innerHTML = h + ":" + m + ":" + s;
  setTimeout(startTime, 1000);
}

function checkTime(i) {
  if (i < 10) {
    i = "0" + i;
  }
  return i;
}
// Clock
