@import url('https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100..900;1,100..900&family=Open+Sans:ital,wght@0,300..800;1,300..800&display=swap');

* {
    padding: 0;
    margin: 0;
    box-sizing: border-box;
}

html,
body {
    width: 100%;
    height: 100%;
}

.navbar {
    height: 45px;
    width: 100%;
    background-color: #000000;
    display: flex;
    justify-content: space-around;
    align-items: center;
    padding: 0 300px;
    color: #fff;
}

.nav-link {
    font-weight: 500;
    font-family: "Montserrat", sans-serif;
    font-optical-sizing: auto;
    font-style: normal;
    font-size: 16px;
    cursor: pointer;
}

i {
    color: black;
}

.sencond-section {
    height: 90vh;
    width: 100%;
    /* border: 1px solid red; */
    display: flex;

}

.sencond-section .left {
    width: 50%;
    height: 90vh;
    /* background-color: limegreen; */
    background-image: url(https://store.storeimages.cdn-apple.com/1/as-images.apple.com/is/iphone-card-40-iphone16prohero-202409?wid=680&hei=528&fmt=p-jpg&qlt=95&.v=MjUrdW9rK0I3Y0hBcFdUR2pNVTRtUFpIU2c1QXYxN1o5THJsVFdubi8vdWo1ZjMweU1kRzVLbG1rVXpHeUhrekM5eTNXTVZyTHIwdUZhZkhwMUhFcDF6UEJkKzg5UTZqNmZVWkpNeWtMWmwzTnQ3S2NXcklFcHlIS3FvK1FqcEU);
    background-position: center;
    background-repeat: no-repeat;
    position: relative;
     background-size: cover;
}

.sencond-section .left .overlay {
    background-color: rgba(0, 0, 0, 0.386);
    width: 100%;
    height: 90vh;
}

.overlay .content{
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    position: absolute;
    color: #fff;
}
.overlay .content h1{
    font-size: 40px;
    font-family: 'Times New Roman', Times, serif;
    font-weight: 100;
}

.overlay .content p{
    padding: 10px 0;
}

.overlay .content button{
    padding: 8px 15px;
    background: transparent;
    border: 1px solid #fff;
    background: white;
    color: black;
    border-radius: 5px;
    cursor: pointer;
}

.sencond-section .right {
    /* background-color: lightcoral; */
    width: 50%;
    background-image: url(https://store.storeimages.cdn-apple.com/1/as-images.apple.com/is/iphone-card-40-iphone16hero-202409?wid=680&hei=528&fmt=p-jpg&qlt=95&.v=MjUrdW9rK0I3Y0hBcFdUR2pNVTRtQVFBVUN4RXE3Y3R0dll5SWIrN0ZjT3h4Q1pzSzliK1BIZFF3RWwzVmo0NlhHUkcvNmtpMGxDZTE1ejhaNlcyMDhpeFZabmFRL2tkSk9HeFdpWGtBay9UT01KOWpHdXNqbndCcFNuZ3JRNmI);
    background-position: center;
    background-repeat: no-repeat;
    position: relative;
    background-size: cover;
}