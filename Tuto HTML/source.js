var profile= {
    Name:"haziq",
    Age:25,
    live:"puncak alam",
    studied:"PTSS",
    location:["my","sg","ws"],
    pelajaran:{
        class:"DTK",
        institusi:"poli",
        iSstillstudied:true,
        kos:["DTK","DOE","DEP"]
    }
}
profile.ketinggian= 178
profile.makanan_kesukaan={
    makanan: "nasi lemak",
    minuman: "laicikang"
}

//create array cars in property 3 cars
var cars= ["honda" , "merc" , "bmw"]
cars.push("proton" , 5 , false)
cars.unshift("toyota" , "tesla")
cars.splice(3,0,"lambo")

console.log(` name:${profile.Name} 
              Age: ${profile.Age} 
              institusi:${profile.pelajaran.institusi}
              class:${profile.pelajaran.class} 
              iSstillstudied:${profile.pelajaran.iSstillstudied}`)

console.log(profile.location[1])

// of guna untuk array sahaja dan terus dapat value //
console.log("")
console.log("guna of")
for(var data of profile.pelajaran.kos){
    console.log(`kos:${data}`)
}

// in guna untuk object & array untuk dapatkan index //
console.log("")
console.log("guna in")
for(var data in profile.pelajaran.kos){
    console.log(profile.pelajaran.kos[data])
}

profile.location.map(x =>{
    console.log(`location :${x}`)
})

console.log("")
console.log(`ketinggian : ${profile.ketinggian}`)

console.log("")
console.log(`makanan : ${profile.makanan_kesukaan.makanan}
minuman : ${profile.makanan_kesukaan.minuman}`)

console.log("")
console.log(cars)

cars.map(x =>{
    console.log(typeof(x))
})

console.log("")
for(var data in cars)
console.log(typeof(cars[data]))


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