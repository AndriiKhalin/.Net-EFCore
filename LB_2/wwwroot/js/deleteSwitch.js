document.addEventListener('DOMContentLoaded', function () {
    const deleteSwitch = document.getElementById('deleteSwitch');
    const deleteButton = document.getElementById('deleteButton');

    deleteSwitch.addEventListener('change', function () {
        deleteButton.disabled = !this.checked;
    });
});