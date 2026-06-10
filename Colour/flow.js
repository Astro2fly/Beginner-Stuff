        function updateTheme() {

            const currentHour= new Date().getHours();
            
            const body= document.body;
            const greeting= document.getElementById("greeting");

            body.className= "";

            if (currentHour >= 6 && currentHour < 12) {
                body.classList.add("morning");
                greeting.textContent= "Good Morning!";
                
            } else if (currentHour >= 12 && currentHour < 17) {
                body.classList.add("afternoon");
                greeting.textContent= "Good Afternoon!";
                
            } else if (currentHour >= 17 && currentHour < 20) {
                body.classList.add("evening");
                greeting.textContent = "Good Evening!";
                
            } else {
                body.classList.add("night");
                greeting.textContent= "Good Night!";
            }
        }

        updateTheme();