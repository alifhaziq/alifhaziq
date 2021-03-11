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

console.log(` name:${profile.Name} 
              Age: ${profile.Age} 
              institusi:${profile.pelajaran.institusi}
              class:${profile.pelajaran.class} 
              iSstillstudied:${profile.pelajaran.iSstillstudied}`)

console.log(profile.location[1])

profile.location.map(x =>{
    console.log(`location :${x}`)
})

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
