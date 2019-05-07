class SlidesEditor extends React.Component {
    constructor() {  
        super();  
        //get storyId
        const storyId = document.getElementById("storyId").innerText;
        this.state = {
            "storyId":storyId,
            "users": [],
            "slides": []
        };
    }

  componentDidMount() {
      fetch('/api/storyAPI/getStorySlides?storyId=' + this.state.storyId)
          .then(res => res.json())
          .then(slides => {
              let newSlides = [];
              for (let i = 0; i < slides.length; i++){
                  newSlides.push({
                      id: i + 1,
                      title: slides[i].title,
                      description: slides[i].description,
                      imgURL: slides[i].url
                  });
              }
              this.setState({
                  "slides": newSlides
              })
          }
        );

//    fetch('/api/user/post', {
//          method: 'POST',
//          headers: {
//            'Content-Type': 'application/json',
//          },
//          body: JSON.stringify({
//            Id: 6,
//            Name: 'bcd',
//            Summary: 'Engineer'
//          })
//     })

  }

addSlideBar = () => {
        let  newSlides = this.state.slides;
        newSlides.push({id:this.state.slides.length+1, title: '', description: '', imgURL:""});
        this.setState({
                    slides: newSlides
                });
        }

removeSlideBar = (n) => {
        let  newSlides = this.state.slides;
        newSlides.splice(n-1, 1);         
        for(let i = 0; i < newSlides.length; i++){
             newSlides[i].id = i+1;
        }
        this.setState({
                    slides: newSlides
                });
        this.render();
        }

updateTitle = (n, title) => {
        let  newSlides = this.state.slides;
        newSlides[n-1].title = title;
        this.setState({
                    slides: newSlides
                });
}

updateDescription = (n, description) => {
        let  newSlides = this.state.slides;
        newSlides[n-1].description = description;
        this.setState({
                    slides: newSlides
                });
}

updateImgURL = (n, url) => {
        let  newSlides = this.state.slides;
        newSlides[n-1].imgURL = url;
        this.setState({
                    slides: newSlides
                });
}

moveUp = (n) => {
        let  newSlides = this.state.slides;
        if(n - 1 != 0){
            let tmp = newSlides[n-2];
            newSlides[n-2] = newSlides[n-1];
            newSlides[n-1] = tmp;
        }
        for(let i = 0; i < newSlides.length; i++){
             newSlides[i].id = i+1;
        }
        this.setState({
                    slides: newSlides
                });
}

moveDown = (n) => {
        let  newSlides = this.state.slides;
        if(n - 1 != newSlides.length - 1){
            let tmp = newSlides[n];
            newSlides[n] = newSlides[n-1];
            newSlides[n-1] = tmp;
        }
        for(let i = 0; i < newSlides.length; i++){
             newSlides[i].id = i+1;
        }
        this.setState({
                    slides: newSlides
                });
}

post = () => {
    var slideModel = { slide: this.state.slides, storyId: this.state.storyId };
    fetch('/api/storyAPI/postStoryBlock', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(slideModel)
          })
}

render() { 
    return (
        <div>
            {
                this.state.slides.map(a =>
                <SlideBar key = {a.id}  
                          slide = {a}
                          removeHandler = {this.removeSlideBar}
                          updateTitleHandler = {this.updateTitle}
                          updateDescriptionHandler = {this.updateDescription}
                          updateImgURLHandler = {this.updateImgURL}
                          moveUpHandler = {this.moveUp}
                          moveDownHandler = {this.moveDown}
                          >
                </SlideBar>)
             }
            <div className = "add-block">
                <button onClick = {this.addSlideBar} >+ Add Story Block</button>
            </div>
            <button className = "post-btn" onClick = {this.post}>Post</button>
        </div>
        );
    }
}