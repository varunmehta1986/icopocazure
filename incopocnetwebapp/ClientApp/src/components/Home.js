import React, { Component } from 'react';

export class Home extends Component {

  constructor(){
    super();
    this.state = {environment: "Loading environment"};
    }
    componentDidMount() {
        this.getEnvironment();
    }

  async getEnvironment() {
      const response = await fetch('/api/environment');
      console.log(response);
    const data = await response.text();
    this.setState({environment:data});
  }

  render () {

    return (
      <div>
        <h1>Hello, world!</h1>
        <h2>{this.state.environment}</h2>
      </div>
    );
  }
}
