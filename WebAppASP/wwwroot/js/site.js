document.addEventListener("DOMContentLoaded", function () {
    let btnMenu = document.querySelector('.btn-mobile')
    let nav = document.querySelector('nav')

    function handleProfileImageUpload() {
        try {
            let fileUploader = document.querySelector('#fileUploader')
            if (fileUploader != undefined) {
                fileUploader.addEventListener('change', function () {
                    if (this.files.length > 0) {
                        this.form.submit()
                    }
                })
            }
        }
        catch { }
    }

    btnMenu.addEventListener('click', () => {
        btnMenu.classList.toggle('active')
        btnMenu.classList.toggle('fixed')

        nav.classList.toggle('active')
    })

    window.addEventListener('resize', () => {
        btnMenu.classList.remove('active')
        btnMenu.classList.remove('fixed')

        nav.classList.remove('active')
    })
})