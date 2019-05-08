class SlidesEditor extends React.Component {
    constructor() {  
        super();  
        const storyId = document.getElementById("storyId").innerText;
        this.state = {
            "storyId":storyId,
            "slides": []
        };
    }

  //---------------< fetch slides data at initial >----------------------
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

  }

//---------------< Add one slide bar >-----------------------------
addSlideBar = () => {
        let  newSlides = this.state.slides;
    newSlides.push({ id: this.state.slides.length + 1, title: '', description: '', imgURL:"\\fileStorage\\images\\blankimage.png"});
        this.setState({
                    slides: newSlides
                });
        }

//---------------< remove slide bar >-----------------------------
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

//---------------< update title >---------------------------------
updateTitle = (n, title) => {
        let  newSlides = this.state.slides;
        newSlides[n-1].title = title;
        this.setState({
                    slides: newSlides
                });
}

//---------------< update description >---------------------------------
updateDescription = (n, description) => {
        let  newSlides = this.state.slides;
        newSlides[n-1].description = description;
        this.setState({
                    slides: newSlides
                });
}

//---------------< update image URL >------------------------------------
updateImgURL = (n, url) => {
        let  newSlides = this.state.slides;
        newSlides[n-1].imgURL = url;
        this.setState({
                    slides: newSlides
                });
}

//---------------< move up slide bar >------------------------------------
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

//---------------< move down slide bar >------------------------------------
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

//---------------< post slides data to server >------------------------------------
post = () => {
    const result = document.getElementById("result");
    result.innerText = "";
    var slideModel = { slide: this.state.slides, storyId: this.state.storyId };
    fetch('/api/storyAPI/postStoryBlock', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(slideModel)
    }).then(function () {
        result.innerText = "Succeed";
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
            <div className = "slideEditor-submit">
                <p id = "result"></p>
                <button className="btn btn-green post-btn" onClick={this.post}>Save</button>
            </div>
        </div>
        );
    }
}