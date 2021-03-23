var profile = {
    Name: "haziq",
    Age: 25,
    live: "puncak alam",
    studied: "PTSS",
    location: ["my", "sg", "ws"],
    pelajaran: {
        class: "DTK",
        institusi: "poli",
        iSstillstudied: true,
        kos: ["DTK", "DOE", "DEP"]
    }
}
profile.ketinggian = 178
profile.makanan_kesukaan = {
    makanan: "nasi lemak",
    minuman: "laicikang"
}

//create array cars in property 3 cars
var cars = ["honda", "merc", "bmw"]
cars.push("proton", 5, false)
cars.unshift("toyota", "tesla")
cars.splice(3, 0, "lambo")

console.log(` name:${profile.Name} 
              Age: ${profile.Age} 
              institusi:${profile.pelajaran.institusi}
              class:${profile.pelajaran.class} 
              iSstillstudied:${profile.pelajaran.iSstillstudied}`)

console.log(profile.location[1])

// of guna untuk array sahaja dan terus dapat value //
console.log("")
console.log("guna of")
for (var data of profile.pelajaran.kos) {
    console.log(`kos:${data}`)
}

// in guna untuk object & array untuk dapatkan index //
console.log("")
console.log("guna in")
for (var data in profile.pelajaran.kos) {
    console.log(profile.pelajaran.kos[data])
}

profile.location.map(x => {
    console.log(`location :${x}`)
})

console.log("")
console.log(`ketinggian : ${profile.ketinggian}`)

console.log("")
console.log(`makanan : ${profile.makanan_kesukaan.makanan}
minuman : ${profile.makanan_kesukaan.minuman}`)

console.log("")
console.log(cars)

cars.map(x => {
    console.log(typeof (x))
})

console.log("")
for (var data in cars)
    console.log(typeof (cars[data]))


console.log("")
{
    var size = 56
    {
        let size = 75
        size = 10
        console.log("size dalam block pink", size)
    }
    console.log("global", size)
}

console.log("")
var a = 10
var name = "haziq"

var data = a != 15 ? 10 : false
console.log(data)

console.log("")
{
    var x = 8
    console.log(x)

    var y = x++
    console.log(y)
}

//practice sendiri//
console.log("")
{
    var x = "haziq"
    console.log("awal", x)
    {
        let z = "zharif"
        console.log("nama bagi block" , z)
    }
    console.log("akhir" , x)
}

console.log("")
{
var a = 25
var b = 3
var z = a * b

console.log(z)
}
var data = z == 75 ? "betul" : "salah"
console.log(data) 


console.log('')
var d = 25
var y = 3
var z = true

if(d >= y){
    console.log(z)
}
else if(d == y){
    console.log(z)
}
else{
    console.log(z)
}


console.log("")
var x = 2
if(x == 10){
    console.log(x)
}
else if(x == 20){
    var a = 1
    var b = 3
    var c = 5
    var d = 7

    this.calculate(c, d)
}
else {
    this.myname()
}
 function myname(){
     console.log("hello world")
 }

 function calculate(a, b, c, d){
     console.log(a + b + c + d)
 }
 
 function calculate(a, b){
     console.log(a - b)
 }

 function calculate(c, d){
     console.log(c * d)
 }

 
//data types
//  - String
//  - Object
//  - Array
//  - Boolean
//  - Number

//practice myself
// var ptss={
//     name: "politeknik tuanku syed sirajuddin",
//     bandar:"arau",
//     poskod:02600,
//     negeri:"perlis",
//     department:6,
//     kos:{
//         jkrv:["ddv" , "dds"],
//         jtmk:"ddt",
//         jph:["dfh", "dev" , "dht"],
//         jpa:["dsk" , "dpm" , "da"],
//         jke:["dtk" , "doe" , "dep"],
//         jkm:"dkm"
//     }
// }

// console.log (`  name:${ptss.name} 
//                 Bandar:${ptss.department}`)

// for (var data in ){
//     console.log(`${ptss.kos[data]}`)
// }   

// for (var data of ptss.kos.jpa){
//     console.log([data])
// }

// console.log(""),
// ptss.kos.jke.map(x =>{
//     console.log(`kos jke :${x}`)
// })